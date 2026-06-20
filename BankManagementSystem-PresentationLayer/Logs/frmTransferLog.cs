using BankManagementSystem_BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BankManagementSystem_PresentationLayer
{
    public partial class frmTransferLog : Form
    {
        DataTable LogsTable = new DataTable();

        public frmTransferLog()
        {
            InitializeComponent();
        }

        private void _AddColumnsToTable()
        {
            DataColumn Col = new DataColumn();

            Col.ColumnName = "TransferID";
            Col.DataType = typeof(int);
            Col.AutoIncrement = true;
            Col.ReadOnly = true;
            Col.Unique = true;
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "TransferDateTime";
            Col.DataType = typeof(DateTime);
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "SenderAccountNumber";
            Col.DataType = typeof(string);
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "ReceiverAccountNumber";
            Col.DataType = typeof(string);
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Amount";
            Col.DataType = typeof(decimal);
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "SenderAccountBalance";
            Col.DataType = typeof(decimal);
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "ReceiverAccountBalance";
            Col.DataType = typeof(decimal);
            LogsTable.Columns.Add(Col);

            Col = new DataColumn();
            Col.ColumnName = "Username";
            Col.DataType = typeof(string);
            LogsTable.Columns.Add(Col);
        }

        private void _AddRow(DataRow DB_Record)
        {
            DataRow logRow = LogsTable.NewRow();
            logRow["TransferID"] = DB_Record["TransferID"];
            logRow["TransferDateTime"] = DB_Record["TransferDateTime"];
            logRow["SenderAccountNumber"] = clsClient.Find(Convert.ToInt32(DB_Record["SenderClientID"])).AccountNumber;
            logRow["ReceiverAccountNumber"] = clsClient.Find(Convert.ToInt32(DB_Record["ReceiverClientID"])).AccountNumber;
            logRow["SenderAccountBalance"] = clsClient.Find(Convert.ToInt32(DB_Record["SenderClientID"])).AccountBalance;
            logRow["ReceiverAccountBalance"] = clsClient.Find(Convert.ToInt32(DB_Record["ReceiverClientID"])).AccountBalance;
            logRow["Amount"] = DB_Record["Amount"];
            logRow["Username"] = clsUser.Find(Convert.ToInt32(DB_Record["UserID"])).Username;
            LogsTable.Rows.Add(logRow);
        }

        private void _AddRowsToTable()
        {
            foreach (DataRow Row in clsTransfer.GetTransfersList().Rows)
            {
                _AddRow(Row);
            }
        }

        private void _SetProportionalFillWeights(DataGridView dgv, int padding = 40)
        {
            Graphics g = dgv.CreateGraphics();
            StringFormat sf = StringFormat.GenericTypographic;

            Font headerFont = dgv.ColumnHeadersDefaultCellStyle.Font ?? dgv.Font;
            Font cellFont = dgv.DefaultCellStyle.Font ?? dgv.Font;

            var idealWidths = new Dictionary<int, float>();

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                // Measure header width
                float headerWidth = g.MeasureString(col.HeaderText + "W", headerFont, int.MaxValue, sf).Width + padding;

                // Measure widest cell value in this column
                float maxCellWidth = 0f;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;
                    string cellText = row.Cells[col.Index].FormattedValue?.ToString() ?? string.Empty;
                    float cellWidth = g.MeasureString(cellText + "W", cellFont, int.MaxValue, sf).Width + padding;
                    if (cellWidth > maxCellWidth) maxCellWidth = cellWidth;
                }

                idealWidths[col.Index] = Math.Max(headerWidth, maxCellWidth);
            }

            float totalIdeal = idealWidths.Values.Sum();

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                // FillWeight is relative — total across all columns doesn't have to equal 100
                // but keeping it at 100-based scale makes it intuitive
                col.FillWeight = (idealWidths[col.Index] / totalIdeal) * 100f;
            }

            // Enable fill mode so weights take effect
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void _CreateTable()
        {
            _AddColumnsToTable();
            _AddRowsToTable();
            DGV_Logs.DataSource = LogsTable;
        }

        private void _SetTextBoxState(TextBox Box, string DefaultText, Color color)
        {
            Box.Text = DefaultText;
            Box.ForeColor = color;
        }

        private void frmTransferLog_Load(object sender, EventArgs e)
        {
            _CreateTable();
            _SetTextBoxState(tbxSearch, "Search by Sender or Receiver Account Number, or Username", Color.Gray);
            _SetProportionalFillWeights(DGV_Logs);
        }

        private void tbxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            _SetTextBoxState(tbxSearch, "", Color.Black);
        }

        private void _FilterResults()
        {
            DataView view = LogsTable.DefaultView;
            if (clsClient.Find(tbxSearch.Text) != null)
                view.RowFilter = $"SenderAccountNumber = '{tbxSearch.Text}' OR ReceiverAccountNumber = '{tbxSearch.Text}'";
            else if (clsUser.Find(tbxSearch.Text) != null)
                view.RowFilter = $"Username = '{tbxSearch.Text}'";
            else
                view.RowFilter = "";
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            tbxSearch.ForeColor = Color.Black;
            _FilterResults();
        }
    }
}