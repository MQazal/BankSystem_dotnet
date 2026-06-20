using System;
using System.Data;
using System.Windows.Forms;
using BankManagementSystem_BusinessLogicLayer;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmAddUpdateClient : Form
    {
        private enum _enMode { AddNew, Update }
        _enMode _Mode;

        clsClient _Client;

        frmManageClients ManageClient;

        private _enMode _SelectMode(int ClientID)
        {
            return ClientID == -1 ? _enMode.AddNew : _enMode.Update;
        }

        private void _InitializeClientObject(int ClientID)
        {
            _Mode = _SelectMode(ClientID);
            if (_Mode == _enMode.Update)
            {
                _Client = clsClient.Find(ClientID);
                if (_Client == null)
                {
                    MessageBox.Show($"This form will be closed because there is no Client with ID = {ClientID}");
                    _CloseForm();
                }
            }
            else
                _Client = new clsClient();
        }

        public frmAddUpdateClient(frmManageClients RunningManage)
        {
            InitializeComponent();
            ManageClient = RunningManage;
            _InitializeClientObject(ManageClient.ClientID);
        }

        private void _LoadNationalites()
        {
            foreach (DataRow Row in clsNationality.GetNationalitiesList().Rows)
            {
                cbxNationality.Items.Add(Row["NationalityName"]);
            }
        }

        private decimal _ConvertTextualBalanceToNumber()
        {
            string BalanceText = default(string);
            for (byte i = 0; i < mskAccountBalance.Text.Length; i++)
            {
                if (char.IsDigit(mskAccountBalance.Text[i]))
                    BalanceText += mskAccountBalance.Text[i];
            }
            return Convert.ToDecimal(BalanceText);
        }

        private void _LoadClientData()
        {
            lblTitle.Text = "Update Client";
            lbl_ID.Text = _Client.ClientID.ToString();
            tbxFName.Text = _Client.FirstName;
            tbxLName.Text = _Client.LastName;
            cbxNationality.SelectedIndex = _Client.NationalityID - 1;
            mskAge.Text = _Client.Age.ToString();
            tbxEmail.Text = _Client.Email;
            mskPhone.Text = _Client.Phone;
            tbxAccountNumber.Text = _Client.AccountNumber;
            tbxPinCode.Text = _Client.PinCode;
            mskAccountBalance.Text = _Client.AccountBalance.ToString();
        }

        private void frmAdd_UpdateClient_Load(object sender, EventArgs e)
        {
            _LoadNationalites();
            if (_Mode == _enMode.Update)
                _LoadClientData();
        }

        private void _SetInputDataToObject()
        {
            // Person Info
            _Client.FirstName = tbxFName.Text;
            _Client.LastName = tbxLName.Text;
            _Client.Age = Convert.ToByte(mskAge.Text);
            _Client.Email = tbxEmail.Text;
            _Client.Phone = mskPhone.Text;
            _Client.NationalityID = cbxNationality.SelectedIndex + 1;

            // Client Info
            _Client.AccountNumber = tbxAccountNumber.Text;
            _Client.PinCode = tbxPinCode.Text;
            _Client.AccountBalance = _ConvertTextualBalanceToNumber();
        }

        private void _PrintClientInfo()
        {
            string ClientInfo = $@"
            PersonID: {_Client.PersonID + "\n"}
            First Name: {_Client.FirstName + "\n"}
            Last Name: {_Client.LastName + "\n"}
            Nationality ID: {_Client.NationalityID + "\n"}
            Age: {_Client.Age + "\n"}
            Email: {_Client.Email + "\n"}
            Phone: {_Client.Phone + "\n"}
            ClientID: {_Client.ClientID + "\n"}
            Acc Number: {_Client.AccountNumber + "\n"}
            PinCode: {_Client.PinCode + "\n"}
            Acc Balanace: {_Client.AccountBalance + "\n"}";
            MessageBox.Show(ClientInfo);
        }

        private string _PrintMessage()
        {
            return (_Mode == _enMode.AddNew) ? "New Client is added sucessfully." : "Client is updated sucessfully";
        }

        private void _ConvertFormToUpdateMode()
        {
            _Mode = _enMode.Update;
            lblTitle.Text = "Update Client";
            lbl_ID.Text = _Client.ClientID.ToString();
        }

        private void _SaveClient()
        {
            _SetInputDataToObject();

            if (_Client.Save())
                MessageBox.Show(_PrintMessage(), "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Operation is failed", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (_Mode == _enMode.AddNew)
            {
                _ConvertFormToUpdateMode();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveClient();
        }
        
        private void _CloseForm()
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
            ManageClient.RefreshClientsRecords();
        }

        private void frmAdd_UpdateClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManageClient.RefreshClientsRecords();
        }
    }
}