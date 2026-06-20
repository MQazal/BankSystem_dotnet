using System;
using System.Windows.Forms;
using BankManagementSystem_BusinessLogicLayer;

namespace BankManagementSystem_PresentationLayer.Transactions
{
    public partial class frmUpdateRate : Form
    {
        frmCurrencyExchange Exchange;

        clsCurrency SelectedCurrency;

        public frmUpdateRate(frmCurrencyExchange Currency)
        {
            InitializeComponent();
            Exchange = Currency;
        }

        private void _LoadCurrencyData()
        {
            tbxCountry.Text = SelectedCurrency.CountryName;
            tbxName.Text = SelectedCurrency.CurrencyName;
            tbxCode.Text = SelectedCurrency.Code;
            tbxOldRate.Text = SelectedCurrency.ExchangeRateUSA.ToString();
        }

        private void frmUpdateRate_Load(object sender, EventArgs e)
        {
            SelectedCurrency = clsCurrency.Find(Exchange.CurrencyID);
            _LoadCurrencyData();
            this.ActiveControl = btnExchange;
        }

        private void _UpdateRate()
        {
            SelectedCurrency.UpdateExchangeRateUSA(Convert.ToDecimal(mskNewRate.Text), SelectedCurrency.CurrencyID);
            MessageBox.Show("Exchange rate updated sucessfully", "Successfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbxOldRate.Text = mskNewRate.Text;
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            _UpdateRate();
        }

        private void frmUpdateRate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exchange.RefreshCurrenciesRecords();
        }
    }
}