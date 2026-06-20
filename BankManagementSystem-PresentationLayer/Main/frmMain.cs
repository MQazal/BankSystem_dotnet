using BankManagementSystem_BusinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmMain : Form
    {
        frmLogin Log;

        private Form _currentForm;

        public frmMain(frmLogin Login)
        {
            InitializeComponent();
            Log = Login;
        }

        private void _ShowCurrentDateTime()
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void _SetUsername()
        {
            lblUsername.Text = clsGlobalUser.CurrentUser.Username;
        }

        private void _DisableAccessToScreen(Button button, Color DisableColor)
        {
            button.Enabled = false;
            button.BackColor = DisableColor;
        }

        private void _SetButtonsPermissionsState()
        {
            foreach(Button button in pnlSidebar.Controls.OfType<Button>())
            {
                if (button == btnHome)
                    continue;
                else
                {
                    byte TagPerm = Convert.ToByte(button.Tag);

                    if ((clsGlobalUser.CurrentUser.PermissionsValue & TagPerm) != TagPerm)
                    {
                        _DisableAccessToScreen(button, Color.LightPink);
                    }
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _SetUsername();
            _ShowCurrentDateTime();
            _SetButtonsPermissionsState();
        }

        private void _OpenForm(Form NewForm)
        {
            if (_currentForm != null)
                _currentForm.Close();
            
            _currentForm = NewForm;
            NewForm.TopLevel = false;
            NewForm.FormBorderStyle = FormBorderStyle.None;
            NewForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(NewForm);
            NewForm.Show(); 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _OpenForm(new frmHome());
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            _OpenForm(new frmManageClients());
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            _OpenForm(new frmTransactionsMenu());
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            _OpenForm(new frmManageUsers());
        }

        private void btnLogHistory_Click(object sender, EventArgs e)
        {
            _OpenForm(new frmLogHistory());
        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            _OpenForm(new frmCurrencyExchange());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Log.Show();
        }
    }
}