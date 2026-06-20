using BankManagementSystem_BusinessLogicLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmAddUpdateUser : Form
    {
        private enum _enMode { AddNew, Update }
        _enMode _Mode;

        clsUser _User;

        frmManageUsers ManageUser;

        public frmAddUpdateUser(frmManageUsers RunningManage)
        {
            InitializeComponent();
            ManageUser = RunningManage;
            _InitializeUserObject(ManageUser.UserID);
        }

        private _enMode _SelectMode(int UserID)
        {
            return UserID == -1 ? _enMode.AddNew : _enMode.Update;
        }

        private void _InitializeUserObject(int UserID)
        {
            _Mode = _SelectMode(UserID);
            if (_Mode == _enMode.Update)
            {
                _User = clsUser.Find(UserID);
                if (_User == null)
                {
                    MessageBox.Show($"This form will be closed because there is no User with ID = {UserID}");
                    _CloseForm();
                }
            }
            else
                _User = new clsUser();
        }

        private void _CloseForm()
        {
            this.Close();
        }

        private void _LoadNationalites()
        {
            foreach (DataRow Row in clsNationality.GetNationalitiesList().Rows)
            {
                cbxNationality.Items.Add(Row["NationalityName"]);
            }
        }

        private void _SelectPermissionsByBitmask()
        {
            if (_User.PermissionsValue == (short)(clsUser.enPermission.HaveAllPermissions))
            {
                chbxAll.Checked = true;
                return;
            }

            if (_User.PermissionsValue == (short)(clsUser.enPermission.BlockUserPermissions))
            {
                chbxBlocked.Checked = true;
                return;
            }

            // exact or combined bitmask

            foreach (CheckBox Box in gbxPermissions.Controls)
            {
                if (Box == chbxAll || Box == chbxBlocked)
                    continue;

                byte TagPerm = Convert.ToByte(Box.Tag);

                if ((_User.PermissionsValue & TagPerm) == TagPerm)
                {
                    Box.Checked = true;
                }
            }
        }

        private void _LoadUserData()
        {
            lblTitle.Text = "Update User";
            lbl_ID.Text = _User.UserID.ToString();
            tbxFName.Text = _User.FirstName;
            tbxLName.Text = _User.LastName;
            cbxNationality.SelectedIndex = _User.NationalityID - 1;
            mskAge.Text = _User.Age.ToString();
            tbxEmail.Text = _User.Email;
            mskPhone.Text = _User.Phone;
            tbxUsername.Text = _User.Username;
            tbxPassword.Text = _User.Password;
            _SelectPermissionsByBitmask();
        }

        private void _PrintUserInfo()
        {
            string UserInfo = $@"
            PersonID: {_User.PersonID + "\n"}
            First Name: {_User.FirstName + "\n"}
            Last Name: {_User.LastName + "\n"}
            Nationality ID: {_User.NationalityID + "\n"}
            Age:      {_User.Age + "\n"}
            Email:    {_User.Email + "\n"}
            Phone:    {_User.Phone + "\n"}
            UserID:   {_User.UserID + "\n"}
            Username: {_User.Username + "\n"}
            Password: {_User.Password + "\n"}
            Permission Value: {_User.PermissionsValue + "\n"}";
            MessageBox.Show(UserInfo);
        }

        private void frmAdd_UpdateUser_Load(object sender, EventArgs e)
        {
            _LoadNationalites();
            this.ActiveControl = gbxPermissions;
            if (_Mode == _enMode.Update)
                _LoadUserData();
           //_PrintUserInfo();
        }

        private void _SetNewPermissions(ref clsUser.stPermissions NewPermissions)
        {
            if (chbxAll.Checked)
            {
                NewPermissions.HaveAllPermissions = true;
                return;
            }

            if (chbxBlocked.Checked)
            {
                NewPermissions.BlockUserPermissions = true;
                return;
            }

            if (chbxManageClients.Checked)
            {
                NewPermissions.pAccessToClientsScreen = true;
            }

            if (chbxAddNew.Checked)
            {
                NewPermissions.pAddNewClient = true;
            }

            if (chbxUpdateClient.Checked)
            {
                NewPermissions.pUpdateClientInfo = true;
            }

            if (chbxDeleteClient.Checked)
            {
                NewPermissions.pDeleteClient = true;
            }

            if (chbxAccessToTransactions.Checked)
            {
                NewPermissions.pAccessToTransactionsScreen = true;
            }

            if (chbxManageUsers.Checked)
            {
                NewPermissions.pAccessToUsersScreen = true;
            }

            if (chbxListLoginRegister.Checked)
            {
                NewPermissions.pListLoginRegister = true;
            }

            if (chbxAccessToCurrencies.Checked)
            {
                NewPermissions.pAccessToCurrencyExchangeScreen = true;
            }
        }

        private void _SetInputDataToObject()
        {
            // Person Info
            _User.FirstName = tbxFName.Text;
            _User.LastName = tbxLName.Text;
            _User.Age = Convert.ToByte(mskAge.Text);
            _User.Email = tbxEmail.Text;
            _User.Phone = mskPhone.Text;
            _User.NationalityID = cbxNationality.SelectedIndex + 1;

            // User Info
            _User.Username = tbxUsername.Text;
            _User.Password = tbxPassword.Text;
            _User.Permission = new clsUser.stPermissions();
            _SetNewPermissions(ref _User.Permission);
        }

        private string _PrintMessage()
        {
            return (_Mode == _enMode.AddNew) ? "New User is added sucessfully." : "User is updated sucessfully";
        }

        private void _ConvertFormToUpdateMode()
        {
            _Mode = _enMode.Update;
            lblTitle.Text = "Update User";
            lbl_ID.Text = _User.UserID.ToString();
        }

        private void _SaveUser()
        {
            _SetInputDataToObject();

            if (_User.Save())
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
            _SaveUser();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
            ManageUser.RefreshUsersRecords();
        }

        private void frmAdd_UpdateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManageUser.RefreshUsersRecords();
        }

        private void _UnchecekdBoxes(CheckBox CheckedBox)
        {
            foreach(CheckBox Box in gbxPermissions.Controls)
            {
                if (Box == CheckedBox)
                    continue;
                else
                    Box.Checked = false;
            }
        }

        private void chbxBlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAll.Checked)
                _UnchecekdBoxes(chbxAll);

            else if (chbxBlocked.Checked)
                _UnchecekdBoxes(chbxBlocked);
        }
    }
}