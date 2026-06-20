namespace BankManagementSystem_PresentationLayer
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            this.cbxNationality = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskAge = new System.Windows.Forms.MaskedTextBox();
            this.tbxLName = new System.Windows.Forms.TextBox();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxPermissions = new System.Windows.Forms.GroupBox();
            this.chbxAccessToCurrencies = new System.Windows.Forms.CheckBox();
            this.ImageListPermissions = new System.Windows.Forms.ImageList(this.components);
            this.chbxManageClients = new System.Windows.Forms.CheckBox();
            this.chbxBlocked = new System.Windows.Forms.CheckBox();
            this.chbxListLoginRegister = new System.Windows.Forms.CheckBox();
            this.chbxManageUsers = new System.Windows.Forms.CheckBox();
            this.chbxAccessToTransactions = new System.Windows.Forms.CheckBox();
            this.chbxDeleteClient = new System.Windows.Forms.CheckBox();
            this.chbxUpdateClient = new System.Windows.Forms.CheckBox();
            this.chbxAddNew = new System.Windows.Forms.CheckBox();
            this.chbxAll = new System.Windows.Forms.CheckBox();
            this.gbxPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxNationality
            // 
            this.cbxNationality.BackColor = System.Drawing.Color.Lavender;
            this.cbxNationality.DropDownHeight = 140;
            this.cbxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNationality.DropDownWidth = 140;
            this.cbxNationality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNationality.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNationality.FormattingEnabled = true;
            this.cbxNationality.IntegralHeight = false;
            this.cbxNationality.Location = new System.Drawing.Point(198, 291);
            this.cbxNationality.MaxDropDownItems = 10;
            this.cbxNationality.Name = "cbxNationality";
            this.cbxNationality.Size = new System.Drawing.Size(197, 34);
            this.cbxNationality.TabIndex = 50;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(534, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 50);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(405, 538);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 50);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(859, 186);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.MaxLength = 20;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(299, 34);
            this.tbxPassword.TabIndex = 45;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label10.Location = new System.Drawing.Point(682, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 27);
            this.label10.TabIndex = 44;
            this.label10.Text = "Password:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(859, 126);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUsername.MaxLength = 20;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(299, 34);
            this.tbxUsername.TabIndex = 43;
            this.tbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label9.Location = new System.Drawing.Point(682, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 27);
            this.label9.TabIndex = 42;
            this.label9.Text = "Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(38, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 27);
            this.label8.TabIndex = 41;
            this.label8.Text = "Phone:";
            // 
            // mskPhone
            // 
            this.mskPhone.BeepOnError = true;
            this.mskPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPhone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mskPhone.Location = new System.Drawing.Point(198, 511);
            this.mskPhone.Margin = new System.Windows.Forms.Padding(4);
            this.mskPhone.Mask = "+\\966000000000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(179, 34);
            this.mskPhone.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(38, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 27);
            this.label7.TabIndex = 39;
            this.label7.Text = "Email:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(198, 441);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.MaxLength = 100;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(455, 34);
            this.tbxEmail.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(38, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 27);
            this.label6.TabIndex = 37;
            this.label6.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(38, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 27);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nationality:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(38, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 27);
            this.label4.TabIndex = 35;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(38, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "First Name:";
            // 
            // mskAge
            // 
            this.mskAge.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAge.Location = new System.Drawing.Point(198, 368);
            this.mskAge.Margin = new System.Windows.Forms.Padding(4);
            this.mskAge.Mask = "00";
            this.mskAge.Name = "mskAge";
            this.mskAge.Size = new System.Drawing.Size(68, 34);
            this.mskAge.SkipLiterals = false;
            this.mskAge.TabIndex = 33;
            this.mskAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxLName
            // 
            this.tbxLName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLName.Location = new System.Drawing.Point(198, 217);
            this.tbxLName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLName.MaxLength = 20;
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(285, 34);
            this.tbxLName.TabIndex = 32;
            this.tbxLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxFName
            // 
            this.tbxFName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFName.Location = new System.Drawing.Point(198, 142);
            this.tbxFName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFName.MaxLength = 20;
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(285, 34);
            this.tbxFName.TabIndex = 31;
            this.tbxFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_ID.Location = new System.Drawing.Point(193, 76);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(42, 27);
            this.lbl_ID.TabIndex = 30;
            this.lbl_ID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 34);
            this.label2.TabIndex = 29;
            this.label2.Text = "User ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblTitle.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTitle.Location = new System.Drawing.Point(551, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 36);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Add New User";
            // 
            // gbxPermissions
            // 
            this.gbxPermissions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxPermissions.Controls.Add(this.chbxAccessToCurrencies);
            this.gbxPermissions.Controls.Add(this.chbxManageClients);
            this.gbxPermissions.Controls.Add(this.chbxBlocked);
            this.gbxPermissions.Controls.Add(this.chbxListLoginRegister);
            this.gbxPermissions.Controls.Add(this.chbxManageUsers);
            this.gbxPermissions.Controls.Add(this.chbxAccessToTransactions);
            this.gbxPermissions.Controls.Add(this.chbxDeleteClient);
            this.gbxPermissions.Controls.Add(this.chbxUpdateClient);
            this.gbxPermissions.Controls.Add(this.chbxAddNew);
            this.gbxPermissions.Controls.Add(this.chbxAll);
            this.gbxPermissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxPermissions.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPermissions.Location = new System.Drawing.Point(675, 256);
            this.gbxPermissions.Name = "gbxPermissions";
            this.gbxPermissions.Size = new System.Drawing.Size(712, 304);
            this.gbxPermissions.TabIndex = 51;
            this.gbxPermissions.TabStop = false;
            this.gbxPermissions.Text = "Permissions:";
            // 
            // chbxAccessToCurrencies
            // 
            this.chbxAccessToCurrencies.AutoSize = true;
            this.chbxAccessToCurrencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxAccessToCurrencies.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxAccessToCurrencies.ImageIndex = 10;
            this.chbxAccessToCurrencies.ImageList = this.ImageListPermissions;
            this.chbxAccessToCurrencies.Location = new System.Drawing.Point(263, 246);
            this.chbxAccessToCurrencies.Name = "chbxAccessToCurrencies";
            this.chbxAccessToCurrencies.Size = new System.Drawing.Size(403, 40);
            this.chbxAccessToCurrencies.TabIndex = 11;
            this.chbxAccessToCurrencies.Tag = "128";
            this.chbxAccessToCurrencies.Text = "Access Currency Exchange Screen";
            this.chbxAccessToCurrencies.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbxAccessToCurrencies.UseVisualStyleBackColor = true;
            // 
            // ImageListPermissions
            // 
            this.ImageListPermissions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListPermissions.ImageStream")));
            this.ImageListPermissions.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListPermissions.Images.SetKeyName(0, "All.png");
            this.ImageListPermissions.Images.SetKeyName(1, "AddC.png");
            this.ImageListPermissions.Images.SetKeyName(2, "MClients.png");
            this.ImageListPermissions.Images.SetKeyName(3, "UpdateC.png");
            this.ImageListPermissions.Images.SetKeyName(4, "Delete.png");
            this.ImageListPermissions.Images.SetKeyName(5, "MUsers.png");
            this.ImageListPermissions.Images.SetKeyName(6, "ShowL.png");
            this.ImageListPermissions.Images.SetKeyName(7, "Transactions.png");
            this.ImageListPermissions.Images.SetKeyName(8, "LogF.png");
            this.ImageListPermissions.Images.SetKeyName(9, "Blocked.png");
            this.ImageListPermissions.Images.SetKeyName(10, "Currencies.png");
            // 
            // chbxManageClients
            // 
            this.chbxManageClients.AutoSize = true;
            this.chbxManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxManageClients.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxManageClients.ImageIndex = 2;
            this.chbxManageClients.ImageList = this.ImageListPermissions;
            this.chbxManageClients.Location = new System.Drawing.Point(323, 49);
            this.chbxManageClients.Name = "chbxManageClients";
            this.chbxManageClients.Size = new System.Drawing.Size(284, 40);
            this.chbxManageClients.TabIndex = 10;
            this.chbxManageClients.Tag = "1";
            this.chbxManageClients.Text = "Access Clients Screen";
            this.chbxManageClients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbxManageClients.UseVisualStyleBackColor = true;
            // 
            // chbxBlocked
            // 
            this.chbxBlocked.AutoSize = true;
            this.chbxBlocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxBlocked.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxBlocked.ImageIndex = 9;
            this.chbxBlocked.ImageList = this.ImageListPermissions;
            this.chbxBlocked.Location = new System.Drawing.Point(139, 45);
            this.chbxBlocked.Name = "chbxBlocked";
            this.chbxBlocked.Size = new System.Drawing.Size(144, 40);
            this.chbxBlocked.TabIndex = 9;
            this.chbxBlocked.Text = "Blocked";
            this.chbxBlocked.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbxBlocked.UseVisualStyleBackColor = true;
            this.chbxBlocked.CheckedChanged += new System.EventHandler(this.chbxBlocked_CheckedChanged);
            // 
            // chbxListLoginRegister
            // 
            this.chbxListLoginRegister.AutoSize = true;
            this.chbxListLoginRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxListLoginRegister.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxListLoginRegister.ImageIndex = 8;
            this.chbxListLoginRegister.ImageList = this.ImageListPermissions;
            this.chbxListLoginRegister.Location = new System.Drawing.Point(323, 187);
            this.chbxListLoginRegister.Name = "chbxListLoginRegister";
            this.chbxListLoginRegister.Size = new System.Drawing.Size(255, 40);
            this.chbxListLoginRegister.TabIndex = 8;
            this.chbxListLoginRegister.Tag = "64";
            this.chbxListLoginRegister.Text = "List Login Register";
            this.chbxListLoginRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbxListLoginRegister.UseVisualStyleBackColor = true;
            // 
            // chbxManageUsers
            // 
            this.chbxManageUsers.AutoSize = true;
            this.chbxManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxManageUsers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxManageUsers.ImageIndex = 5;
            this.chbxManageUsers.ImageList = this.ImageListPermissions;
            this.chbxManageUsers.Location = new System.Drawing.Point(323, 141);
            this.chbxManageUsers.Name = "chbxManageUsers";
            this.chbxManageUsers.Size = new System.Drawing.Size(277, 40);
            this.chbxManageUsers.TabIndex = 7;
            this.chbxManageUsers.Tag = "32";
            this.chbxManageUsers.Text = "Access Users Screen";
            this.chbxManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbxManageUsers.UseVisualStyleBackColor = true;
            // 
            // chbxAccessToTransactions
            // 
            this.chbxAccessToTransactions.AutoSize = true;
            this.chbxAccessToTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxAccessToTransactions.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxAccessToTransactions.ImageIndex = 7;
            this.chbxAccessToTransactions.ImageList = this.ImageListPermissions;
            this.chbxAccessToTransactions.Location = new System.Drawing.Point(323, 95);
            this.chbxAccessToTransactions.Name = "chbxAccessToTransactions";
            this.chbxAccessToTransactions.Size = new System.Drawing.Size(343, 40);
            this.chbxAccessToTransactions.TabIndex = 6;
            this.chbxAccessToTransactions.Tag = "16";
            this.chbxAccessToTransactions.Text = "Access Transactions Screen";
            this.chbxAccessToTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbxAccessToTransactions.UseVisualStyleBackColor = true;
            // 
            // chbxDeleteClient
            // 
            this.chbxDeleteClient.AutoSize = true;
            this.chbxDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxDeleteClient.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxDeleteClient.ImageIndex = 4;
            this.chbxDeleteClient.ImageList = this.ImageListPermissions;
            this.chbxDeleteClient.Location = new System.Drawing.Point(17, 247);
            this.chbxDeleteClient.Name = "chbxDeleteClient";
            this.chbxDeleteClient.Size = new System.Drawing.Size(194, 40);
            this.chbxDeleteClient.TabIndex = 4;
            this.chbxDeleteClient.Tag = "8";
            this.chbxDeleteClient.Text = "Delete Client";
            this.chbxDeleteClient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbxDeleteClient.UseVisualStyleBackColor = true;
            // 
            // chbxUpdateClient
            // 
            this.chbxUpdateClient.AutoSize = true;
            this.chbxUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxUpdateClient.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxUpdateClient.ImageIndex = 3;
            this.chbxUpdateClient.ImageList = this.ImageListPermissions;
            this.chbxUpdateClient.Location = new System.Drawing.Point(17, 183);
            this.chbxUpdateClient.Name = "chbxUpdateClient";
            this.chbxUpdateClient.Size = new System.Drawing.Size(202, 40);
            this.chbxUpdateClient.TabIndex = 3;
            this.chbxUpdateClient.Tag = "4";
            this.chbxUpdateClient.Text = "Update Client";
            this.chbxUpdateClient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbxUpdateClient.UseVisualStyleBackColor = true;
            // 
            // chbxAddNew
            // 
            this.chbxAddNew.AutoSize = true;
            this.chbxAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxAddNew.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxAddNew.ImageIndex = 1;
            this.chbxAddNew.ImageList = this.ImageListPermissions;
            this.chbxAddNew.Location = new System.Drawing.Point(17, 117);
            this.chbxAddNew.Name = "chbxAddNew";
            this.chbxAddNew.Size = new System.Drawing.Size(222, 40);
            this.chbxAddNew.TabIndex = 1;
            this.chbxAddNew.Tag = "2";
            this.chbxAddNew.Text = "Add New Client";
            this.chbxAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbxAddNew.UseVisualStyleBackColor = true;
            // 
            // chbxAll
            // 
            this.chbxAll.AutoSize = true;
            this.chbxAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxAll.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxAll.ImageIndex = 0;
            this.chbxAll.ImageList = this.ImageListPermissions;
            this.chbxAll.Location = new System.Drawing.Point(17, 49);
            this.chbxAll.Name = "chbxAll";
            this.chbxAll.Size = new System.Drawing.Size(96, 40);
            this.chbxAll.TabIndex = 0;
            this.chbxAll.Text = "All";
            this.chbxAll.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbxAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbxAll.UseVisualStyleBackColor = true;
            this.chbxAll.CheckedChanged += new System.EventHandler(this.chbxBlocked_CheckedChanged);
            // 
            // frmAdd_UpdateUser
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1390, 600);
            this.Controls.Add(this.gbxPermissions);
            this.Controls.Add(this.cbxNationality);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskAge);
            this.Controls.Add(this.tbxLName);
            this.Controls.Add(this.tbxFName);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAdd_UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Update User Screen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdd_UpdateUser_FormClosing);
            this.Load += new System.EventHandler(this.frmAdd_UpdateUser_Load);
            this.gbxPermissions.ResumeLayout(false);
            this.gbxPermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNationality;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskAge;
        private System.Windows.Forms.TextBox tbxLName;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxPermissions;
        private System.Windows.Forms.CheckBox chbxAddNew;
        private System.Windows.Forms.CheckBox chbxAll;
        private System.Windows.Forms.CheckBox chbxListLoginRegister;
        private System.Windows.Forms.CheckBox chbxManageUsers;
        private System.Windows.Forms.CheckBox chbxAccessToTransactions;
        private System.Windows.Forms.CheckBox chbxDeleteClient;
        private System.Windows.Forms.CheckBox chbxUpdateClient;
        private System.Windows.Forms.CheckBox chbxBlocked;
        private System.Windows.Forms.ImageList ImageListPermissions;
        private System.Windows.Forms.CheckBox chbxManageClients;
        private System.Windows.Forms.CheckBox chbxAccessToCurrencies;
    }
}