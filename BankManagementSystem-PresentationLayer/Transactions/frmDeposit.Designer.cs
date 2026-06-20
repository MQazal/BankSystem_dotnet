namespace BankManagementSystem_PresentationLayer
{
    partial class frmDeposit
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
            this.gbxClient = new System.Windows.Forms.GroupBox();
            this.mskAccountBalance = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPinCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAccountNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskDepositAmount = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxClient
            // 
            this.gbxClient.BackColor = System.Drawing.Color.Gainsboro;
            this.gbxClient.Controls.Add(this.mskAccountBalance);
            this.gbxClient.Controls.Add(this.label6);
            this.gbxClient.Controls.Add(this.tbxPinCode);
            this.gbxClient.Controls.Add(this.label5);
            this.gbxClient.Controls.Add(this.tbxAccountNumber);
            this.gbxClient.Controls.Add(this.label4);
            this.gbxClient.Controls.Add(this.label3);
            this.gbxClient.Controls.Add(this.label2);
            this.gbxClient.Controls.Add(this.tbxFullName);
            this.gbxClient.Controls.Add(this.lbl_ID);
            this.gbxClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxClient.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxClient.Location = new System.Drawing.Point(0, 124);
            this.gbxClient.Name = "gbxClient";
            this.gbxClient.Size = new System.Drawing.Size(649, 357);
            this.gbxClient.TabIndex = 0;
            this.gbxClient.TabStop = false;
            this.gbxClient.Text = "Client Card";
            // 
            // mskAccountBalance
            // 
            this.mskAccountBalance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAccountBalance.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskAccountBalance.Location = new System.Drawing.Point(257, 300);
            this.mskAccountBalance.Margin = new System.Windows.Forms.Padding(4);
            this.mskAccountBalance.Mask = "000000 S\\AR";
            this.mskAccountBalance.Name = "mskAccountBalance";
            this.mskAccountBalance.ReadOnly = true;
            this.mskAccountBalance.Size = new System.Drawing.Size(141, 34);
            this.mskAccountBalance.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(13, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "Balance:";
            // 
            // tbxPinCode
            // 
            this.tbxPinCode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPinCode.Location = new System.Drawing.Point(264, 242);
            this.tbxPinCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPinCode.MaxLength = 4;
            this.tbxPinCode.Name = "tbxPinCode";
            this.tbxPinCode.ReadOnly = true;
            this.tbxPinCode.Size = new System.Drawing.Size(134, 34);
            this.tbxPinCode.TabIndex = 33;
            this.tbxPinCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "PinCode:";
            // 
            // tbxAccountNumber
            // 
            this.tbxAccountNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccountNumber.Location = new System.Drawing.Point(264, 187);
            this.tbxAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAccountNumber.MaxLength = 4;
            this.tbxAccountNumber.Name = "tbxAccountNumber";
            this.tbxAccountNumber.ReadOnly = true;
            this.tbxAccountNumber.Size = new System.Drawing.Size(134, 34);
            this.tbxAccountNumber.TabIndex = 27;
            this.tbxAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Account Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 37);
            this.label2.TabIndex = 27;
            this.label2.Text = "Client ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // tbxFullName
            // 
            this.tbxFullName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFullName.Location = new System.Drawing.Point(168, 117);
            this.tbxFullName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFullName.MaxLength = 20;
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.ReadOnly = true;
            this.tbxFullName.Size = new System.Drawing.Size(307, 34);
            this.tbxFullName.TabIndex = 29;
            this.tbxFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_ID.Location = new System.Drawing.Point(149, 55);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(51, 34);
            this.lbl_ID.TabIndex = 28;
            this.lbl_ID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Deposite Amount:";
            // 
            // mskDepositAmount
            // 
            this.mskDepositAmount.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDepositAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskDepositAmount.Location = new System.Drawing.Point(340, 39);
            this.mskDepositAmount.Margin = new System.Windows.Forms.Padding(4);
            this.mskDepositAmount.Mask = "000000";
            this.mskDepositAmount.Name = "mskDepositAmount";
            this.mskDepositAmount.Size = new System.Drawing.Size(135, 39);
            this.mskDepositAmount.TabIndex = 25;
            this.mskDepositAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Khaki;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(500, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 50);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDeposit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(649, 481);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mskDepositAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit Screen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            this.gbxClient.ResumeLayout(false);
            this.gbxClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDepositAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAccountNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPinCode;
        private System.Windows.Forms.MaskedTextBox mskAccountBalance;
    }
}