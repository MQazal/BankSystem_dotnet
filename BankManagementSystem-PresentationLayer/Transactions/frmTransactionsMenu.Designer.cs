namespace BankManagementSystem_PresentationLayer
{
    partial class frmTransactionsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionsMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ImageListTransactions = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAccountNumber = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransferLog = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.DGV_Clients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageListTransactions
            // 
            this.ImageListTransactions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListTransactions.ImageStream")));
            this.ImageListTransactions.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListTransactions.Images.SetKeyName(0, "Deposit.png");
            this.ImageListTransactions.Images.SetKeyName(1, "Withdraw.png");
            this.ImageListTransactions.Images.SetKeyName(2, "Transfer.png");
            this.ImageListTransactions.Images.SetKeyName(3, "Tran Log.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Transactions";
            // 
            // tbxAccountNumber
            // 
            this.tbxAccountNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbxAccountNumber.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccountNumber.Location = new System.Drawing.Point(383, 157);
            this.tbxAccountNumber.MaxLength = 4;
            this.tbxAccountNumber.Name = "tbxAccountNumber";
            this.tbxAccountNumber.Size = new System.Drawing.Size(431, 34);
            this.tbxAccountNumber.TabIndex = 18;
            this.tbxAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxAccountNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxAccountNumber_MouseClick);
            this.tbxAccountNumber.TextChanged += new System.EventHandler(this.tbxAccountNumber_TextChanged);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Honeydew;
            this.btnDeposit.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ImageIndex = 0;
            this.btnDeposit.ImageList = this.ImageListTransactions;
            this.btnDeposit.Location = new System.Drawing.Point(102, 85);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(188, 50);
            this.btnDeposit.TabIndex = 13;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransferLog
            // 
            this.btnTransferLog.BackColor = System.Drawing.Color.Linen;
            this.btnTransferLog.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferLog.ImageIndex = 3;
            this.btnTransferLog.ImageList = this.ImageListTransactions;
            this.btnTransferLog.Location = new System.Drawing.Point(771, 85);
            this.btnTransferLog.Name = "btnTransferLog";
            this.btnTransferLog.Size = new System.Drawing.Size(235, 50);
            this.btnTransferLog.TabIndex = 17;
            this.btnTransferLog.Text = "Transfer Log";
            this.btnTransferLog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTransferLog.UseVisualStyleBackColor = false;
            this.btnTransferLog.Click += new System.EventHandler(this.btnTransferLog_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnTransfer.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ImageIndex = 2;
            this.btnTransfer.ImageList = this.ImageListTransactions;
            this.btnTransfer.Location = new System.Drawing.Point(542, 85);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(214, 50);
            this.btnTransfer.TabIndex = 15;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Linen;
            this.btnWithdraw.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ImageIndex = 1;
            this.btnWithdraw.ImageList = this.ImageListTransactions;
            this.btnWithdraw.Location = new System.Drawing.Point(307, 85);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(218, 50);
            this.btnWithdraw.TabIndex = 14;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // DGV_Clients
            // 
            this.DGV_Clients.AllowUserToAddRows = false;
            this.DGV_Clients.AllowUserToDeleteRows = false;
            this.DGV_Clients.AllowUserToOrderColumns = true;
            this.DGV_Clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Clients.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.DGV_Clients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Clients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Clients.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Clients.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Clients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Clients.Location = new System.Drawing.Point(0, 205);
            this.DGV_Clients.MultiSelect = false;
            this.DGV_Clients.Name = "DGV_Clients";
            this.DGV_Clients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Clients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Clients.RowHeadersWidth = 51;
            this.DGV_Clients.RowTemplate.Height = 24;
            this.DGV_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Clients.Size = new System.Drawing.Size(1226, 422);
            this.DGV_Clients.TabIndex = 19;
            // 
            // frmTransaction
            // 
            this.AcceptButton = this.btnDeposit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1226, 627);
            this.Controls.Add(this.DGV_Clients);
            this.Controls.Add(this.tbxAccountNumber);
            this.Controls.Add(this.btnTransferLog);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions Screen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.ImageList ImageListTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTransferLog;
        private System.Windows.Forms.TextBox tbxAccountNumber;
        protected System.Windows.Forms.DataGridView DGV_Clients;
    }
}