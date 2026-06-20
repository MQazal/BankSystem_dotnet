using System;
using System.Windows.Forms;
using BankManagementSystem_BusinessLogicLayer;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmDeposit : Form
    {
        frmTransactionsMenu Deposit;

        public frmDeposit(frmTransactionsMenu CurrentDeposit)
        {
            InitializeComponent();
            Deposit = CurrentDeposit;
        }

        private void _LoadData()
        {
            lbl_ID.Text = Deposit.SelectedClient.ClientID.ToString();
            tbxFullName.Text = Deposit.SelectedClient.FirstName + ' ' + Deposit.SelectedClient.LastName;
            tbxAccountNumber.Text = Deposit.SelectedClient.AccountNumber;
            tbxPinCode.Text = Deposit.SelectedClient.PinCode;
            mskAccountBalance.Text = Deposit.SelectedClient.AccountBalance.ToString();
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            _LoadData();
            this.ActiveControl = gbxClient;
        }

        private void _PerformDeposit()
        {
            if (MessageBox.Show("Are you sure you want to make a deposit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Deposit.SelectedClient.Deposite(Convert.ToDecimal(mskDepositAmount.Text)))
                {
                    MessageBox.Show("Deposit done sucessfully", "Sucessfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskAccountBalance.Text = Deposit.SelectedClient.AccountBalance.ToString();
                }
                else
                    MessageBox.Show("Deposit is failed", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _CloseForm()
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _PerformDeposit();
            _CloseForm();
            Deposit.RefreshClientsRecords();
        }
    }
}