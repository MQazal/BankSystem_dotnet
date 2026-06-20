namespace BankManagementSystem_PresentationLayer
{
    partial class frmTransfer
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
            this.gbxSender = new System.Windows.Forms.GroupBox();
            this.mskSenderBalance = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSenderPinCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSenderAccountNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSenderFullName = new System.Windows.Forms.TextBox();
            this.lbl_SenderID = new System.Windows.Forms.Label();
            this.mskTransferAmount = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxReceiver = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxFindAccNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mskReceiverBalance = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxReceiverPinCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxReceiverAccountNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxReceiverFullName = new System.Windows.Forms.TextBox();
            this.lbl_ReceiverID = new System.Windows.Forms.Label();
            this.btnPerform = new System.Windows.Forms.Button();
            this.gbxSender.SuspendLayout();
            this.gbxReceiver.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSender
            // 
            this.gbxSender.BackColor = System.Drawing.Color.Gainsboro;
            this.gbxSender.Controls.Add(this.mskSenderBalance);
            this.gbxSender.Controls.Add(this.label6);
            this.gbxSender.Controls.Add(this.tbxSenderPinCode);
            this.gbxSender.Controls.Add(this.label5);
            this.gbxSender.Controls.Add(this.tbxSenderAccountNumber);
            this.gbxSender.Controls.Add(this.label4);
            this.gbxSender.Controls.Add(this.label3);
            this.gbxSender.Controls.Add(this.label2);
            this.gbxSender.Controls.Add(this.tbxSenderFullName);
            this.gbxSender.Controls.Add(this.lbl_SenderID);
            this.gbxSender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxSender.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSender.Location = new System.Drawing.Point(56, 168);
            this.gbxSender.Name = "gbxSender";
            this.gbxSender.Size = new System.Drawing.Size(495, 357);
            this.gbxSender.TabIndex = 27;
            this.gbxSender.TabStop = false;
            this.gbxSender.Text = "Sender Client Card";
            // 
            // mskSenderBalance
            // 
            this.mskSenderBalance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSenderBalance.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskSenderBalance.Location = new System.Drawing.Point(264, 300);
            this.mskSenderBalance.Margin = new System.Windows.Forms.Padding(4);
            this.mskSenderBalance.Mask = "000000 S\\AR";
            this.mskSenderBalance.Name = "mskSenderBalance";
            this.mskSenderBalance.ReadOnly = true;
            this.mskSenderBalance.Size = new System.Drawing.Size(141, 34);
            this.mskSenderBalance.TabIndex = 35;
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
            // tbxSenderPinCode
            // 
            this.tbxSenderPinCode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenderPinCode.Location = new System.Drawing.Point(264, 242);
            this.tbxSenderPinCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSenderPinCode.MaxLength = 4;
            this.tbxSenderPinCode.Name = "tbxSenderPinCode";
            this.tbxSenderPinCode.ReadOnly = true;
            this.tbxSenderPinCode.Size = new System.Drawing.Size(134, 34);
            this.tbxSenderPinCode.TabIndex = 33;
            this.tbxSenderPinCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tbxSenderAccountNumber
            // 
            this.tbxSenderAccountNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenderAccountNumber.Location = new System.Drawing.Point(264, 187);
            this.tbxSenderAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSenderAccountNumber.MaxLength = 4;
            this.tbxSenderAccountNumber.Name = "tbxSenderAccountNumber";
            this.tbxSenderAccountNumber.ReadOnly = true;
            this.tbxSenderAccountNumber.Size = new System.Drawing.Size(134, 34);
            this.tbxSenderAccountNumber.TabIndex = 27;
            this.tbxSenderAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tbxSenderFullName
            // 
            this.tbxSenderFullName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenderFullName.Location = new System.Drawing.Point(168, 117);
            this.tbxSenderFullName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSenderFullName.MaxLength = 20;
            this.tbxSenderFullName.Name = "tbxSenderFullName";
            this.tbxSenderFullName.ReadOnly = true;
            this.tbxSenderFullName.Size = new System.Drawing.Size(307, 34);
            this.tbxSenderFullName.TabIndex = 29;
            this.tbxSenderFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_SenderID
            // 
            this.lbl_SenderID.AutoSize = true;
            this.lbl_SenderID.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SenderID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_SenderID.Location = new System.Drawing.Point(149, 55);
            this.lbl_SenderID.Name = "lbl_SenderID";
            this.lbl_SenderID.Size = new System.Drawing.Size(51, 34);
            this.lbl_SenderID.TabIndex = 28;
            this.lbl_SenderID.Text = "???";
            // 
            // mskTransferAmount
            // 
            this.mskTransferAmount.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTransferAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskTransferAmount.Location = new System.Drawing.Point(504, 67);
            this.mskTransferAmount.Margin = new System.Windows.Forms.Padding(4);
            this.mskTransferAmount.Mask = "000000";
            this.mskTransferAmount.Name = "mskTransferAmount";
            this.mskTransferAmount.Size = new System.Drawing.Size(135, 39);
            this.mskTransferAmount.TabIndex = 29;
            this.mskTransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(196, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter Transfer Amount:";
            // 
            // gbxReceiver
            // 
            this.gbxReceiver.BackColor = System.Drawing.Color.Gainsboro;
            this.gbxReceiver.Controls.Add(this.btnFind);
            this.gbxReceiver.Controls.Add(this.tbxFindAccNumber);
            this.gbxReceiver.Controls.Add(this.label13);
            this.gbxReceiver.Controls.Add(this.label12);
            this.gbxReceiver.Controls.Add(this.mskReceiverBalance);
            this.gbxReceiver.Controls.Add(this.label7);
            this.gbxReceiver.Controls.Add(this.tbxReceiverPinCode);
            this.gbxReceiver.Controls.Add(this.label8);
            this.gbxReceiver.Controls.Add(this.tbxReceiverAccountNumber);
            this.gbxReceiver.Controls.Add(this.label9);
            this.gbxReceiver.Controls.Add(this.label10);
            this.gbxReceiver.Controls.Add(this.label11);
            this.gbxReceiver.Controls.Add(this.tbxReceiverFullName);
            this.gbxReceiver.Controls.Add(this.lbl_ReceiverID);
            this.gbxReceiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxReceiver.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReceiver.Location = new System.Drawing.Point(596, 137);
            this.gbxReceiver.Name = "gbxReceiver";
            this.gbxReceiver.Size = new System.Drawing.Size(494, 455);
            this.gbxReceiver.TabIndex = 30;
            this.gbxReceiver.TabStop = false;
            this.gbxReceiver.Text = "Receiver Client Card";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Pink;
            this.btnFind.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(374, 70);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(101, 50);
            this.btnFind.TabIndex = 32;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbxFindAccNumber
            // 
            this.tbxFindAccNumber.BackColor = System.Drawing.Color.PowderBlue;
            this.tbxFindAccNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFindAccNumber.Location = new System.Drawing.Point(32, 80);
            this.tbxFindAccNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFindAccNumber.MaxLength = 4;
            this.tbxFindAccNumber.Name = "tbxFindAccNumber";
            this.tbxFindAccNumber.Size = new System.Drawing.Size(322, 34);
            this.tbxFindAccNumber.TabIndex = 37;
            this.tbxFindAccNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxFindAccNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxFindAccNumber_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-5, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(516, 26);
            this.label13.TabIndex = 36;
            this.label13.Text = "____________________________________";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-5, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(516, 26);
            this.label12.TabIndex = 32;
            this.label12.Text = "____________________________________";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mskReceiverBalance
            // 
            this.mskReceiverBalance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskReceiverBalance.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskReceiverBalance.Location = new System.Drawing.Point(264, 406);
            this.mskReceiverBalance.Margin = new System.Windows.Forms.Padding(4);
            this.mskReceiverBalance.Mask = "000000 S\\AR";
            this.mskReceiverBalance.Name = "mskReceiverBalance";
            this.mskReceiverBalance.ReadOnly = true;
            this.mskReceiverBalance.Size = new System.Drawing.Size(141, 34);
            this.mskReceiverBalance.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(13, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Balance:";
            // 
            // tbxReceiverPinCode
            // 
            this.tbxReceiverPinCode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReceiverPinCode.Location = new System.Drawing.Point(264, 348);
            this.tbxReceiverPinCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxReceiverPinCode.MaxLength = 4;
            this.tbxReceiverPinCode.Name = "tbxReceiverPinCode";
            this.tbxReceiverPinCode.ReadOnly = true;
            this.tbxReceiverPinCode.Size = new System.Drawing.Size(134, 34);
            this.tbxReceiverPinCode.TabIndex = 33;
            this.tbxReceiverPinCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(12, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "PinCode:";
            // 
            // tbxReceiverAccountNumber
            // 
            this.tbxReceiverAccountNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReceiverAccountNumber.Location = new System.Drawing.Point(264, 293);
            this.tbxReceiverAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxReceiverAccountNumber.MaxLength = 4;
            this.tbxReceiverAccountNumber.Name = "tbxReceiverAccountNumber";
            this.tbxReceiverAccountNumber.ReadOnly = true;
            this.tbxReceiverAccountNumber.Size = new System.Drawing.Size(134, 34);
            this.tbxReceiverAccountNumber.TabIndex = 27;
            this.tbxReceiverAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(12, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 29);
            this.label9.TabIndex = 31;
            this.label9.Text = "Account Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(13, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 29);
            this.label10.TabIndex = 30;
            this.label10.Text = "Full Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(13, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 37);
            this.label11.TabIndex = 27;
            this.label11.Text = "Client ID:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label11.UseCompatibleTextRendering = true;
            // 
            // tbxReceiverFullName
            // 
            this.tbxReceiverFullName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReceiverFullName.Location = new System.Drawing.Point(168, 223);
            this.tbxReceiverFullName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxReceiverFullName.MaxLength = 20;
            this.tbxReceiverFullName.Name = "tbxReceiverFullName";
            this.tbxReceiverFullName.ReadOnly = true;
            this.tbxReceiverFullName.Size = new System.Drawing.Size(307, 34);
            this.tbxReceiverFullName.TabIndex = 29;
            this.tbxReceiverFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ReceiverID
            // 
            this.lbl_ReceiverID.AutoSize = true;
            this.lbl_ReceiverID.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReceiverID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_ReceiverID.Location = new System.Drawing.Point(149, 161);
            this.lbl_ReceiverID.Name = "lbl_ReceiverID";
            this.lbl_ReceiverID.Size = new System.Drawing.Size(51, 34);
            this.lbl_ReceiverID.TabIndex = 28;
            this.lbl_ReceiverID.Text = "???";
            // 
            // btnPerform
            // 
            this.btnPerform.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPerform.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerform.Location = new System.Drawing.Point(679, 56);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(128, 50);
            this.btnPerform.TabIndex = 31;
            this.btnPerform.Text = "Perform";
            this.btnPerform.UseVisualStyleBackColor = false;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // frmTransfer
            // 
            this.AcceptButton = this.btnPerform;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 608);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.gbxReceiver);
            this.Controls.Add(this.gbxSender);
            this.Controls.Add(this.mskTransferAmount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Screen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTransfer_FormClosing);
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.gbxSender.ResumeLayout(false);
            this.gbxSender.PerformLayout();
            this.gbxReceiver.ResumeLayout(false);
            this.gbxReceiver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSender;
        private System.Windows.Forms.MaskedTextBox mskSenderBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSenderPinCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSenderAccountNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSenderFullName;
        private System.Windows.Forms.Label lbl_SenderID;
        private System.Windows.Forms.MaskedTextBox mskTransferAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxReceiver;
        private System.Windows.Forms.MaskedTextBox mskReceiverBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxReceiverPinCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxReceiverAccountNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxReceiverFullName;
        private System.Windows.Forms.Label lbl_ReceiverID;
        private System.Windows.Forms.Button btnPerform;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxFindAccNumber;
        private System.Windows.Forms.Label label13;
    }
}