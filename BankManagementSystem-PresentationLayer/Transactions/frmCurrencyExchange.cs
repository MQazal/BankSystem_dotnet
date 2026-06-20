using BankManagementSystem_BusinessLogicLayer;
using BankManagementSystem_PresentationLayer.Transactions;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace BankManagementSystem_PresentationLayer
{
    public partial class frmCurrencyExchange : Form
    {
        DataTable CurrenciesTable = new DataTable();

        public int CurrencyID = default(int);

        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();
            Col.ColumnName = "CurrencyID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.ReadOnly = true;
            Col.Unique = true;
            CurrenciesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Country";
            Col.DataType = typeof(string);
            CurrenciesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Name";
            Col.DataType = typeof(string);
            CurrenciesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Code";
            Col.DataType = typeof(string);
            CurrenciesTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "ExchangeRateUSA";
            Col.DataType = typeof(decimal);
            CurrenciesTable.Columns.Add(Col);
        }

        private void _AddRowsToTable()
        {
            foreach (DataRow Row in clsCurrency.GetCurrenciesList().Rows)
            {
                CurrenciesTable.Rows.Add(Row["CurrencyID"], Row["Country"], Row["Name"], Row["Code"], Row["ExchangeRateUSA"]);
            }
        }

        private void _CreateTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            DGV_Currencies.DataSource = CurrenciesTable;
        }

        private void _SetTextBoxState(TextBox Box, string DefaultText, Color color)
        {
            Box.Text = DefaultText;
            Box.ForeColor = color;
        }

        private void frmCurrencyExchange_Load(object sender, EventArgs e)
        {
            _SetTextBoxState(tbxFindCurrency, "Search by Currency Code", Color.Gray);
            _CreateTable();
            this.ActiveControl = DGV_Currencies;
        }

        private void tbxFindCurrency_MouseClick(object sender, MouseEventArgs e)
        {
            _SetTextBoxState(tbxFindCurrency, "", Color.Black);
        }

        private void _FilterResultsByCurrencyCode()
        {
            DataView view = CurrenciesTable.DefaultView;
            if (clsCurrency.Find(tbxFindCurrency.Text) != null)
                view.RowFilter = $"Code = '{tbxFindCurrency.Text}'";
            else
                view.RowFilter = "";
        }

        private void tbxFindCurrency_TextChanged(object sender, EventArgs e)
        {
            tbxFindCurrency.ForeColor = Color.Black;
            _FilterResultsByCurrencyCode();
        }

        private void _OpenForm(Form form)
        {
            form.ShowDialog();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            _OpenForm(new frmExchange());
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            CurrencyID = Convert.ToInt32(DGV_Currencies.CurrentRow.Cells[0].Value);
            _OpenForm(new frmUpdateRate(this));
        }

        private void _ClearTableRows()
        {
            CurrenciesTable.Rows.Clear();
        }

        public void RefreshCurrenciesRecords()
        {
            _ClearTableRows();
            _AddRowsToTable();
        }
    }
}