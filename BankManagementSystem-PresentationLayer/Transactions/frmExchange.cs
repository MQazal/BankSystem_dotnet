using BankManagementSystem_BusinessLogicLayer;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using System;
using System.Windows.Forms;
using System.Data;

namespace BankManagementSystem_PresentationLayer.Transactions
{
    public partial class frmExchange : Form
    {
        public frmExchange()
        {
            InitializeComponent();
        }

        clsCurrency Currency1;

        clsCurrency Currency2;

        private void _LoadCurrencies(ComboBox cbx)
        {
            foreach (DataRow Row in clsCurrency.GetCurrenciesList().Rows)
            {
                cbx.Items.Add(Row["Code"]);
            }
        }

        private void frmExchange_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pbxImage;
            _LoadCurrencies(cbxGroupCurrency1);
            _LoadCurrencies(cbxGroupCurrency2);
        }

        private void _PerformConverting()
        {
            Currency1 = clsCurrency.Find(cbxGroupCurrency1.SelectedItem.ToString());
            Currency2 = clsCurrency.Find(cbxGroupCurrency2.SelectedItem.ToString());

            if (Currency2.Code == "USD")
            {
                tbxResult.Text =
                    $"The amount transferred is equal to {Currency1.ConvertCurrencyToUSD(Convert.ToDecimal(mskAmount.Text))} USD";
            }
            else
            {
                tbxResult.Text =
                    $"The amount transferred is equal to {Currency1.ConvertToOtherCurrency((Convert.ToDecimal(mskAmount.Text)), Currency2.ExchangeRateUSA)} {Currency2.Code}";
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            _PerformConverting();
        }
    }
}