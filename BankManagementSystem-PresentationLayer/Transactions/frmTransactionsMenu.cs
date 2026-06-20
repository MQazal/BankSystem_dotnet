using BankManagementSystem_BusinessLogicLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmTransactionsMenu : Form
    {
        DataTable ClientsTable = new DataTable();

        public clsClient SelectedClient;

        public frmTransactionsMenu()
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
            Col.ColumnName = "ClientID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
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

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            _SetTextBoxState(tbxAccountNumber, "Search By Account Number", Color.Gray);
            _CreateTable();
            this.ActiveControl = btnDeposit;
        }

        private void tbxAccountNumber_MouseClick(object sender, MouseEventArgs e)
        {
            _SetTextBoxState(tbxAccountNumber, "", Color.Black);
        }

        private void tbxAccountNumber_TextChanged(object sender, EventArgs e)
        {
            tbxAccountNumber.ForeColor = Color.Black;
            _FilterResultsByAccountNumber();
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

        private void _OpenDepositForm()
        {
            if (DGV_Clients.CurrentRow == null)
            {
                MessageBox.Show("Select a client to perform transaction!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedClient = clsClient.Find((int)DGV_Clients.CurrentRow.Cells[0].Value);
            frmDeposit NewDeposit = new frmDeposit(this);
            NewDeposit.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            _OpenDepositForm();
        }

        private void _OpenWithdrawForm()
        {
            if (DGV_Clients.CurrentRow == null)
            {
                MessageBox.Show("Select a client to perform transaction!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedClient = clsClient.Find((int)DGV_Clients.CurrentRow.Cells[0].Value);
            frmWithdraw NewWithdraw = new frmWithdraw(this);
            NewWithdraw.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            _OpenWithdrawForm();
        }

        private void _OpenTransferForm()
        {
            if (DGV_Clients.CurrentRow == null)
            {
                MessageBox.Show("Select a client to perform transaction!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SelectedClient = clsClient.Find((int)DGV_Clients.CurrentRow.Cells[0].Value);
            frmTransfer NewTransfer = new frmTransfer(this);
            NewTransfer.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            _OpenTransferForm();
        }

        private void _OpenTransferLogForm()
        {
            frmTransferLog Log = new frmTransferLog();
            Log.ShowDialog();
        }

        private void btnTransferLog_Click(object sender, EventArgs e)
        {
            _OpenTransferLogForm();
        }
    }
}