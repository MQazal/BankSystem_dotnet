namespace BankManagementSystem_PresentationLayer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ImageListMain = new System.Windows.Forms.ImageList(this.components);
            this.btnLogHistory = new System.Windows.Forms.Button();
            this.btnCurrencyExchange = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnManageClients = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Silver;
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnLogHistory);
            this.pnlSidebar.Controls.Add(this.btnCurrencyExchange);
            this.pnlSidebar.Controls.Add(this.btnManageUsers);
            this.pnlSidebar.Controls.Add(this.btnTransaction);
            this.pnlSidebar.Controls.Add(this.btnManageClients);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.lblDateTime);
            this.pnlSidebar.Controls.Add(this.lblUsername);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 626);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.ImageIndex = 6;
            this.btnLogout.ImageList = this.ImageListMain;
            this.btnLogout.Location = new System.Drawing.Point(2, 571);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(244, 43);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ImageListMain
            // 
            this.ImageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListMain.ImageStream")));
            this.ImageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListMain.Images.SetKeyName(0, "Home.png");
            this.ImageListMain.Images.SetKeyName(1, "MC.png");
            this.ImageListMain.Images.SetKeyName(2, "Tran.png");
            this.ImageListMain.Images.SetKeyName(3, "MUsers.png");
            this.ImageListMain.Images.SetKeyName(4, "CuEx.png");
            this.ImageListMain.Images.SetKeyName(5, "History.png");
            this.ImageListMain.Images.SetKeyName(6, "Logout.png");
            // 
            // btnLogHistory
            // 
            this.btnLogHistory.FlatAppearance.BorderSize = 0;
            this.btnLogHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogHistory.ImageIndex = 5;
            this.btnLogHistory.ImageList = this.ImageListMain;
            this.btnLogHistory.Location = new System.Drawing.Point(3, 390);
            this.btnLogHistory.Name = "btnLogHistory";
            this.btnLogHistory.Size = new System.Drawing.Size(243, 39);
            this.btnLogHistory.TabIndex = 7;
            this.btnLogHistory.Tag = "64";
            this.btnLogHistory.Text = "Log History";
            this.btnLogHistory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogHistory.UseVisualStyleBackColor = true;
            this.btnLogHistory.Click += new System.EventHandler(this.btnLogHistory_Click);
            // 
            // btnCurrencyExchange
            // 
            this.btnCurrencyExchange.FlatAppearance.BorderSize = 0;
            this.btnCurrencyExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencyExchange.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCurrencyExchange.ImageIndex = 4;
            this.btnCurrencyExchange.ImageList = this.ImageListMain;
            this.btnCurrencyExchange.Location = new System.Drawing.Point(3, 451);
            this.btnCurrencyExchange.Name = "btnCurrencyExchange";
            this.btnCurrencyExchange.Size = new System.Drawing.Size(244, 50);
            this.btnCurrencyExchange.TabIndex = 6;
            this.btnCurrencyExchange.Tag = "128";
            this.btnCurrencyExchange.Text = "Currency Exchange";
            this.btnCurrencyExchange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCurrencyExchange.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCurrencyExchange.UseVisualStyleBackColor = true;
            this.btnCurrencyExchange.Click += new System.EventHandler(this.btnCurrencyExchange_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageUsers.ImageIndex = 3;
            this.btnManageUsers.ImageList = this.ImageListMain;
            this.btnManageUsers.Location = new System.Drawing.Point(3, 324);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(244, 43);
            this.btnManageUsers.TabIndex = 5;
            this.btnManageUsers.Tag = "32";
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransaction.ImageIndex = 2;
            this.btnTransaction.ImageList = this.ImageListMain;
            this.btnTransaction.Location = new System.Drawing.Point(3, 262);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(244, 42);
            this.btnTransaction.TabIndex = 4;
            this.btnTransaction.Tag = "16";
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnManageClients
            // 
            this.btnManageClients.FlatAppearance.BorderSize = 0;
            this.btnManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageClients.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageClients.ImageIndex = 1;
            this.btnManageClients.ImageList = this.ImageListMain;
            this.btnManageClients.Location = new System.Drawing.Point(3, 200);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.Size = new System.Drawing.Size(244, 44);
            this.btnManageClients.TabIndex = 3;
            this.btnManageClients.Tag = "1";
            this.btnManageClients.Text = "Manage Clients";
            this.btnManageClients.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageClients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnManageClients.UseVisualStyleBackColor = true;
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Silver;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.ImageIndex = 0;
            this.btnHome.ImageList = this.ImageListMain;
            this.btnHome.Location = new System.Drawing.Point(3, 139);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(243, 41);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(12, 82);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(104, 27);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "DateTime";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(77, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 27);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1134, 626);
            this.pnlContent.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1384, 626);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnManageClients;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogHistory;
        private System.Windows.Forms.Button btnCurrencyExchange;
        private System.Windows.Forms.ImageList ImageListMain;
    }
}