using System;
using System.Windows.Forms;
using BankManagementSystem_BusinessLogicLayer;
using System.Drawing;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void _SetTotalBalances()
        {
            lblTotalBalances.Text = clsClient.GetTotalBalances().ToString();
        }

        private void _SetTotalClients()
        {
            lblTotalClients.Text = clsClient.GetTotalClients().ToString();
        }

        private void _SetTotalUsers()
        {
            lblTotalUsers.Text = clsUser.GetTotalUsers().ToString();
        }

        private void _SetTotalTransfers()
        {
            lblTotalTransfers.Text = clsTransfer.GetTransfersNumber().ToString();
        }

        private void _SetBackgroundImage()
        {
            pbxImage.Image = Image.FromFile(@"C:\Favorite\BankImag.jpeg");
            pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            _SetTotalBalances();
            _SetTotalClients();
            _SetTotalUsers();
            _SetTotalTransfers();
            _SetBackgroundImage();
        }
    }
}