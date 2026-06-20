using BankManagementSystem_BusinessLogicLayer;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmLogHistory : Form
    {
        DataTable LogsTable = new DataTable();

        public frmLogHistory()
        {
            InitializeComponent();
        }

        private void _SetTextBoxState(TextBox Box, string DefaultText, Color color)
        {
            Box.Text = DefaultText;
            Box.ForeColor = color;
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();
            Col.ColumnName = "LoginID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.ReadOnly = true;
            Col.Unique = true;
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "LoginDateTime";
            Col.DataType = typeof(DateTime);
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Username";
            Col.DataType = typeof(string);
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Password";
            Col.DataType = typeof(string);
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Permissions";
            Col.DataType = typeof(short);
            LogsTable.Columns.Add(Col);
        }

        private void _AddRow(DataRow DB_Record)
        {
            DataRow logRow = LogsTable.NewRow();

            logRow["LoginID"] = DB_Record["LoginID"];

            logRow["LoginDateTime"] = DB_Record["LoginDateTime"];

            logRow["Username"] = clsUser.Find(Convert.ToInt32(DB_Record["UserID"])).Username;

            logRow["Password"] = clsUser.Find(Convert.ToInt32(DB_Record["UserID"])).Password;

            logRow["Permissions"] = clsUser.Find(Convert.ToInt32(DB_Record["UserID"])).PermissionsValue;

            LogsTable.Rows.Add(logRow);
        }

        private void _AddRowsToTable()
        {
            foreach (DataRow Row in clsLogin.GetLogList().Rows)
            {
                _AddRow(Row);
            }
        }

        private void _CreateTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            DGV_Logs.DataSource = LogsTable;
        }

        private void frmLogHistory_Load(object sender, EventArgs e)
        {
            _SetTextBoxState(tbxUsername, "Search by username", Color.Gray);
            _CreateTable();
            this.ActiveControl = DGV_Logs;
        }

        private void tbxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            _SetTextBoxState(tbxUsername, "", Color.Black);
        }

        private void _FilterResultsByUsername()
        {
            DataView view = LogsTable.DefaultView;
            if (clsUser.Find(tbxUsername.Text) != null)
                view.RowFilter = $"Username = '{tbxUsername.Text}'";
            else
                view.RowFilter = "";
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            tbxUsername.ForeColor = Color.Black;
            _FilterResultsByUsername();
        }
    }
}