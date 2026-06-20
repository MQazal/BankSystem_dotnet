using BankManagementSystem_BusinessLogicLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmTransfer : Form
    {
        frmTransactionsMenu Transfer;

        clsClient Receiver;

        public frmTransfer(frmTransactionsMenu CurrentTransfer)
        {
            InitializeComponent();
            Transfer = CurrentTransfer;
        }

        private void _LoadSenderData()
        {
            lbl_SenderID.Text = Transfer.SelectedClient.ClientID.ToString();
            tbxSenderFullName.Text = Transfer.SelectedClient.FirstName + ' ' + Transfer.SelectedClient.LastName;
            tbxSenderAccountNumber.Text = Transfer.SelectedClient.AccountNumber;
            tbxSenderPinCode.Text = Transfer.SelectedClient.PinCode;
            mskSenderBalance.Text = Transfer.SelectedClient.AccountBalance.ToString();
        }

        private void _SetTextBoxState(TextBox Box, string DefaultText, Color color)
        {
            Box.Text = DefaultText;
            Box.ForeColor = color;
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            _LoadSenderData();
            _SetTextBoxState(tbxFindAccNumber, "Search By Account Number", Color.Gray);
            this.ActiveControl = gbxSender;
        }

        private void tbxFindAccNumber_MouseClick(object sender, MouseEventArgs e)
        {
            _SetTextBoxState(tbxFindAccNumber, "", Color.Black);
        }

        private bool _IsReceiverExist()
        {
            return Receiver != null;
        }

        private void _LoadReceiverData()
        {
            lbl_ReceiverID.Text = Receiver.ClientID.ToString();
            tbxReceiverFullName.Text = Receiver.FirstName + ' ' + Receiver.LastName;
            tbxReceiverAccountNumber.Text = Receiver.AccountNumber;
            tbxReceiverPinCode.Text = Receiver.PinCode;
            mskReceiverBalance.Text = Receiver.AccountBalance.ToString();
        }

        private void _ShowReceiverClient()
        {
            Receiver = clsClient.Find(tbxFindAccNumber.Text);
            if (_IsReceiverExist())
                _LoadReceiverData();
            else
                MessageBox.Show("Receiver client is not exist!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _ShowReceiverClient();
        }

        private void _UpdateBalances()
        {
            mskSenderBalance.Text = Transfer.SelectedClient.AccountBalance.ToString();
            mskReceiverBalance.Text = Receiver.AccountBalance.ToString();
        }

        private void _PerformTransfer()
        {
            if (Receiver == null)
            {
                MessageBox.Show("Receiver Client data is empty", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to make a transfer?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Transfer.SelectedClient.Transfer(Convert.ToDecimal(mskTransferAmount.Text), ref Receiver, clsGlobalUser.CurrentUser.UserID))
                {
                    MessageBox.Show("Transfer done sucessfully", "Sucessfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _UpdateBalances();
                }
                else
                    MessageBox.Show("Transfer is failed", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            _PerformTransfer();
        }

        private void frmTransfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Transfer.RefreshClientsRecords();
        }
    }
}