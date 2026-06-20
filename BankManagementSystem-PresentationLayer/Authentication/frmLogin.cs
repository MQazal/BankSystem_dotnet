using BankManagementSystem_BusinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void _SetBackgroundImage()
        {
            this.BackgroundImage = Properties.Resources.Wall7;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void _SetTextBoxState(TextBox Box, string DefaultText, Color color, bool IsPasswordBox, char PasswordChar = ' ')
        {
            Box.Text = DefaultText;
            Box.ForeColor = color;

            if (IsPasswordBox)
            {
                Box.PasswordChar = '\0';
            }

            if (PasswordChar != ' ')
            {
                Box.PasswordChar = PasswordChar;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _SetBackgroundImage();
            _SetTextBoxState(tbxUsername, "Username", Color.Gray, false);
            _SetTextBoxState(tbxPassword, "Password", Color.Gray, true);
            this.ActiveControl = btnLogin;
        }

        private void tbxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbxUsername.Text != "Username")
                return;
            _SetTextBoxState(tbxUsername, "", Color.Black, false);
        }

        private void tbxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbxPassword.Text != "Password")
                return;
            _SetTextBoxState(tbxPassword, "", Color.Black, false, '*');
        }

        private void _ChangePasswordVisibility()
        {
            if (chbxShowPass.Checked)
                tbxPassword.PasswordChar = '\0';
            else
                tbxPassword.PasswordChar = '*';
        }

        private void chbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            _ChangePasswordVisibility();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _SetTextBoxState(tbxUsername, "Username", Color.Gray, false);
            _SetTextBoxState(tbxPassword, "Password", Color.Gray, true);
        }

        private void _ClearForm()
        {
            _SetTextBoxState(tbxUsername, "Username", Color.Gray, false);
            _SetTextBoxState(tbxPassword, "Password", Color.Gray, true);
        }

        private void _CreateGlobalSystemUser(clsUser ValidUser)
        {
            clsGlobalUser.CurrentUser = new clsGlobalUser(ValidUser);
        }

        private void _OpenMainMenuScreen()
        {
            frmMain Main = new frmMain(this);
            Main.Show();
            _ClearForm();
            this.Hide();
        }

        private void _PrintUserInfo()
        {
            string UserInfo = $@"
            PersonID: {clsGlobalUser.CurrentUser.PersonID + "\n"}
            First Name: {clsGlobalUser.CurrentUser.FirstName + "\n"}
            Last Name: {clsGlobalUser.CurrentUser.LastName + "\n"}
            Nationality ID: {clsGlobalUser.CurrentUser.NationalityID + "\n"}
            Age: {clsGlobalUser.CurrentUser.Age + "\n"}
            Email: {clsGlobalUser.CurrentUser.Email + "\n"}
            Phone: {clsGlobalUser.CurrentUser.Phone + "\n"}
            UserID: {clsGlobalUser.CurrentUser.UserID + "\n"}
            Username: {clsGlobalUser.CurrentUser.Username + "\n"}
            Password: {clsGlobalUser.CurrentUser.Password + "\n"}
            Permission Value: {clsGlobalUser.CurrentUser.PermissionsValue + "\n"}";
            MessageBox.Show(UserInfo);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.IsUserValid(tbxUsername.Text, tbxPassword.Text);
            if (User != null)
            {
                _CreateGlobalSystemUser(User);
                //_PrintUserInfo();
                clsLogin.AddLogin(DateTime.Now, clsGlobalUser.CurrentUser.UserID);
                _OpenMainMenuScreen();
            }
            else
                MessageBox.Show("Username or Password is incorrect!\nTry again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}