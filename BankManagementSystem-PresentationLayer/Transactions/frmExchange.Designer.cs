namespace BankManagementSystem_PresentationLayer.Transactions
{
    partial class frmExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExchange));
            this.btnConvert = new System.Windows.Forms.Button();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.mskAmount = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGroupCurrency1 = new System.Windows.Forms.ComboBox();
            this.cbxGroupCurrency2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(151, 258);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(146, 50);
            this.btnConvert.TabIndex = 15;
            this.btnConvert.Text = "Convert";
            this.btnConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbxImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxImage.BackgroundImage")));
            this.pbxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxImage.Location = new System.Drawing.Point(471, 0);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(395, 443);
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // tbxResult
            // 
            this.tbxResult.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbxResult.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResult.Location = new System.Drawing.Point(45, 337);
            this.tbxResult.MaxLength = 200;
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(354, 76);
            this.tbxResult.TabIndex = 16;
            this.tbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskAmount
            // 
            this.mskAmount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskAmount.Location = new System.Drawing.Point(246, 182);
            this.mskAmount.Margin = new System.Windows.Forms.Padding(4);
            this.mskAmount.Mask = "00000000";
            this.mskAmount.Name = "mskAmount";
            this.mskAmount.Size = new System.Drawing.Size(199, 34);
            this.mskAmount.TabIndex = 25;
            this.mskAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Enter Amount:";
            // 
            // cbxGroupCurrency1
            // 
            this.cbxGroupCurrency1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxGroupCurrency1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxGroupCurrency1.BackColor = System.Drawing.Color.Khaki;
            this.cbxGroupCurrency1.DropDownHeight = 140;
            this.cbxGroupCurrency1.DropDownWidth = 140;
            this.cbxGroupCurrency1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxGroupCurrency1.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGroupCurrency1.FormattingEnabled = true;
            this.cbxGroupCurrency1.IntegralHeight = false;
            this.cbxGroupCurrency1.Location = new System.Drawing.Point(246, 48);
            this.cbxGroupCurrency1.MaxDropDownItems = 10;
            this.cbxGroupCurrency1.Name = "cbxGroupCurrency1";
            this.cbxGroupCurrency1.Size = new System.Drawing.Size(199, 34);
            this.cbxGroupCurrency1.TabIndex = 28;
            // 
            // cbxGroupCurrency2
            // 
            this.cbxGroupCurrency2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxGroupCurrency2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxGroupCurrency2.BackColor = System.Drawing.Color.Khaki;
            this.cbxGroupCurrency2.DropDownHeight = 140;
            this.cbxGroupCurrency2.DropDownWidth = 140;
            this.cbxGroupCurrency2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxGroupCurrency2.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGroupCurrency2.FormattingEnabled = true;
            this.cbxGroupCurrency2.IntegralHeight = false;
            this.cbxGroupCurrency2.Location = new System.Drawing.Point(246, 114);
            this.cbxGroupCurrency2.MaxDropDownItems = 10;
            this.cbxGroupCurrency2.Name = "cbxGroupCurrency2";
            this.cbxGroupCurrency2.Size = new System.Drawing.Size(199, 34);
            this.cbxGroupCurrency2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = "Currency1 Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "Currency2 Code:";
            // 
            // frmExchange
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(866, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxGroupCurrency2);
            this.Controls.Add(this.cbxGroupCurrency1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskAmount);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.pbxImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exchange Screen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.MaskedTextBox mskAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGroupCurrency1;
        private System.Windows.Forms.ComboBox cbxGroupCurrency2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}