using BankManagementSystem_BusinessLogicLayer;
using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmManageClients : Form
    {
        public frmManageClients()
        {
            InitializeComponent();
        }

        DataTable ClientsTable = new DataTable();

        public int ClientID = default(int);

        private void frmManageClients_Load(object sender, EventArgs e)
        {
            _CreateTable();
            DGV_Clients.ClearSelection();
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();
            Col.ColumnName = "ClientID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            //Col.AutoIncrementSeed = 1;
            //Col.AutoIncrementStep = 1;
            Col.ReadOnly = true;
            Col.Unique = true;
            ClientsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "AccountNumber";
            Col.DataType = typeof(string);
            ClientsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "PinCode";
            Col.DataType = typeof(string);
            ClientsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "AccountBalance";
            Col.DataType = typeof(decimal);
            ClientsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "PersonID";
            Col.DataType = typeof(int);
            Col.ReadOnly = true;
            Col.Unique = true;
            ClientsTable.Columns.Add(Col);
        }

        private void _AddRowsToTable()
        {
            foreach (DataRow Row in clsClient.GetClientsList().Rows)
            {
                ClientsTable.Rows.Add(Row["ClientID"], Row["AccountNumber"], Row["PinCode"], Row["AccountBalance"], Row["PersonID"]);
            }
        }

        private void _CreateTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            DGV_Clients.DataSource = ClientsTable;
        }

        private void _FilterResultsByAccountNumber()
        {
            DataView view = ClientsTable.DefaultView;
            if (clsClient.Find(tbxAccountNumber.Text) != null)
                view.RowFilter = $"AccountNumber = '{tbxAccountNumber.Text}'";
            else
                view.RowFilter = "";
        }

        private void tbxAccountNumber_TextChanged(object sender, EventArgs e)
        {
            tbxAccountNumber.ForeColor = Color.Black;
            _FilterResultsByAccountNumber();
        }

        private void _OpenAddUpdateClientForm()
        {
            frmAddUpdateClient Add = new frmAddUpdateClient(this);
            Add.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clsGlobalUser.CurrentUser.CheckAccessPermission(clsUser.enPermission.pAddNewClient))
            {
                this.ClientID = -1;
                _OpenAddUpdateClientForm();
            }
            else
                MessageBox.Show("Access Denied! Contact your Admin.", "Block Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsGlobalUser.CurrentUser.CheckAccessPermission(clsUser.enPermission.pUpdateClientInfo))
            {
                this.ClientID = Convert.ToInt32(DGV_Clients.CurrentRow.Cells[0].Value);
                _OpenAddUpdateClientForm();
            }
            else
                MessageBox.Show("Access Denied! Contact your Admin.", "Block Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _ClearTableRows()
        {
            ClientsTable.Rows.Clear();
        }

        public void RefreshClientsRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
        }

        private void _DeleteSelectedRecord()
        {
            clsClient.Delete(Convert.ToInt32(DGV_Clients.CurrentRow.Cells[0].Value));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsGlobalUser.CurrentUser.CheckAccessPermission(clsUser.enPermission.pDeleteClient))
            {
                if (MessageBox.Show("Are you sure you want to delete this client?", "Delete Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show("Client is deleted sucessfully", "Sucessfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _DeleteSelectedRecord();
                    RefreshClientsRecords();
                }
            }
            else
                MessageBox.Show("Access Denied! Contact your Admin.", "Block Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}