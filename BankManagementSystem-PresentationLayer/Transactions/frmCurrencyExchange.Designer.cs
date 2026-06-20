namespace BankManagementSystem_PresentationLayer
{
    partial class frmCurrencyExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrencyExchange));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFindCurrency = new System.Windows.Forms.TextBox();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.DGV_Currencies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Currencies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currencies Exchanges";
            // 
            // tbxFindCurrency
            // 
            this.tbxFindCurrency.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbxFindCurrency.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFindCurrency.Location = new System.Drawing.Point(249, 102);
            this.tbxFindCurrency.MaxLength = 4;
            this.tbxFindCurrency.Name = "tbxFindCurrency";
            this.tbxFindCurrency.Size = new System.Drawing.Size(354, 34);
            this.tbxFindCurrency.TabIndex = 11;
            this.tbxFindCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxFindCurrency.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxFindCurrency_MouseClick);
            this.tbxFindCurrency.TextChanged += new System.EventHandler(this.tbxFindCurrency_TextChanged);
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateRate.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRate.Image")));
            this.btnUpdateRate.Location = new System.Drawing.Point(868, 86);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(222, 50);
            this.btnUpdateRate.TabIndex = 13;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateRate.UseVisualStyleBackColor = false;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.Color.LightGreen;
            this.btnExchange.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.Image = ((System.Drawing.Image)(resources.GetObject("btnExchange.Image")));
            this.btnExchange.Location = new System.Drawing.Point(637, 86);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(207, 50);
            this.btnExchange.TabIndex = 12;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // DGV_Currencies
            // 
            this.DGV_Currencies.AllowUserToAddRows = false;
            this.DGV_Currencies.AllowUserToDeleteRows = false;
            this.DGV_Currencies.AllowUserToOrderColumns = true;
            this.DGV_Currencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Currencies.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.DGV_Currencies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Currencies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Currencies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Currencies.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Currencies.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Currencies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Currencies.Location = new System.Drawing.Point(0, 216);
            this.DGV_Currencies.MultiSelect = false;
            this.DGV_Currencies.Name = "DGV_Currencies";
            this.DGV_Currencies.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Currencies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Currencies.RowHeadersWidth = 51;
            this.DGV_Currencies.RowTemplate.Height = 24;
            this.DGV_Currencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Currencies.Size = new System.Drawing.Size(1173, 458);
            this.DGV_Currencies.TabIndex = 14;
            // 
            // frmCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1173, 674);
            this.Controls.Add(this.DGV_Currencies);
            this.Controls.Add(this.btnUpdateRate);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.tbxFindCurrency);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCurrencyExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currencies Screen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCurrencyExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Currencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFindCurrency;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.Button btnExchange;
        protected System.Windows.Forms.DataGridView DGV_Currencies;
    }
}