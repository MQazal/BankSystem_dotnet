using System;
using System.Windows.Forms;
using BankManagementSystem_BusinessLogicLayer;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmWithdraw : Form
    {
        frmTransactionsMenu Withdraw;

        public frmWithdraw(frmTransactionsMenu CurrentWithdraw)
        {
            InitializeComponent();
            Withdraw = CurrentWithdraw;
        }

        private void _LoadData()
        {
            lbl_ID.Text = Withdraw.SelectedClient.ClientID.ToString();
            tbxFullName.Text = Withdraw.SelectedClient.FirstName + ' ' + Withdraw.SelectedClient.LastName;
            tbxAccountNumber.Text = Withdraw.SelectedClient.AccountNumber;
            tbxPinCode.Text = Withdraw.SelectedClient.PinCode;
            mskAccountBalance.Text = Withdraw.SelectedClient.AccountBalance.ToString();
            lblNote.Text += Withdraw.SelectedClient.AccountBalance.ToString();
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            _LoadData();
            this.ActiveControl = gbxClient;
        }

        private void _PerformWithdraw()
        {
            if (MessageBox.Show("Are you sure you want to make a withdraw?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Withdraw.SelectedClient.Withdraw(Convert.ToDecimal(mskWithdrawAmount.Text)))
                {
                    MessageBox.Show("Withdraw done sucessfully", "Sucessfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskAccountBalance.Text = Withdraw.SelectedClient.AccountBalance.ToString();
                }
                else
                    MessageBox.Show("Withdraw is failed", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _CloseForm()
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _PerformWithdraw();
            _CloseForm();
            Withdraw.RefreshClientsRecords();
        }
    }
}