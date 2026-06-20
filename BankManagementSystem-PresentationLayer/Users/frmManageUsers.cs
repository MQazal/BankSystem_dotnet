using BankManagementSystem_BusinessLogicLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        DataTable UsersTable = new DataTable();

        public int UserID = default(int);

        private void _SetTextBoxState(TextBox Box, string DefaultText, Color color)
        {
            Box.Text = DefaultText;
            Box.ForeColor = color;
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();
            Col.ColumnName = "UserID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.ReadOnly = true;
            Col.Unique = true;
            UsersTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Username";
            Col.DataType = typeof(string);
            UsersTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Password";
            Col.DataType = typeof(string);
            UsersTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Permission";
            Col.DataType = typeof(short);
            UsersTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "PersonID";
            Col.DataType = typeof(int);
            Col.ReadOnly = true;
            Col.Unique = true;
            UsersTable.Columns.Add(Col);
        }

        private void _AddRowsToTable()
        {
            foreach (DataRow Row in clsUser.GetUsersList().Rows)
            {
                UsersTable.Rows.Add(Row["UserID"], Row["Username"], clsUser._DecryptPassword(Row["Password"].ToString()), Row["Permission"], Row["PersonID"]);
            }
        }

        private void _CreateTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            DGV_Users.DataSource = UsersTable;
        }

        private void _FilterResultsByUsername()
        {
            DataView view = UsersTable.DefaultView;
            if (clsUser.Find(tbxUsername.Text) != null)
                view.RowFilter = $"Username = '{tbxUsername.Text}'";
            else
                view.RowFilter = "";
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _SetTextBoxState(tbxUsername, "Search By Username", Color.Gray);
            _CreateTable();
            this.ActiveControl = btnAdd;
        }

        private void tbxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            _SetTextBoxState(tbxUsername, "", Color.Black);
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            tbxUsername.ForeColor = Color.Black;
            _FilterResultsByUsername();
        }

        private void _OpenAddUpdateUserForm()
        {
            frmAddUpdateUser User = new frmAddUpdateUser(this);
            User.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.UserID = -1;
            _OpenAddUpdateUserForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.UserID = Convert.ToInt32(DGV_Users.CurrentRow.Cells[0].Value);
            _OpenAddUpdateUserForm();
        }

        private void _ClearTableRows()
        {
            UsersTable.Rows.Clear();
        }

        public void RefreshUsersRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
        }

        private void _DeleteSelectedUser()
        {
            if (DGV_Users.CurrentRow == null)
                MessageBox.Show("You don't select a user to delete!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (Convert.ToInt32(DGV_Users.CurrentRow.Cells[0].Value) == clsGlobalUser.CurrentUser.UserID) // current user
                {
                    MessageBox.Show("You cannot delete this user because it is in use now!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DGV_Users.CurrentRow.Cells[1].Value.ToString() == "Admin") // User wants to delete Admin account
                {
                    MessageBox.Show("You cannot delete Admin, without him, the system cannot be used!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this user?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsUser.Delete(Convert.ToInt32(DGV_Users.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("User is deleted sucessfully", "Sucessfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshUsersRecords();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _DeleteSelectedUser();
        }
    }
}