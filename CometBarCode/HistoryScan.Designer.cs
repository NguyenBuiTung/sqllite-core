namespace CometBarCode
{
    partial class HistoryScan
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btnSearch = new Button();
            textBoxSearch = new TextBox();
            lblProgressPercentage = new Label();
            progressBarExport = new ProgressBar();
            btnExcel = new Button();
            btnViewHistory = new Button();
            dataGridViewHistory = new DataGridView();
            dateTimePickerTo = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(lblProgressPercentage);
            panel1.Controls.Add(progressBarExport);
            panel1.Controls.Add(btnExcel);
            panel1.Controls.Add(btnViewHistory);
            panel1.Controls.Add(dataGridViewHistory);
            panel1.Controls.Add(dateTimePickerTo);
            panel1.Controls.Add(dateTimePickerFrom);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1303, 649);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 14;
            label1.Text = "Nhập mã code : ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1001, 42);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 32);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(29, 45);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(161, 29);
            textBoxSearch.TabIndex = 12;
            // 
            // lblProgressPercentage
            // 
            lblProgressPercentage.AutoSize = true;
            lblProgressPercentage.Location = new Point(804, 612);
            lblProgressPercentage.Name = "lblProgressPercentage";
            lblProgressPercentage.Size = new Size(26, 21);
            lblProgressPercentage.TabIndex = 11;
            lblProgressPercentage.Text = "%";
            // 
            // progressBarExport
            // 
            progressBarExport.Location = new Point(497, 612);
            progressBarExport.Name = "progressBarExport";
            progressBarExport.Size = new Size(286, 23);
            progressBarExport.TabIndex = 10;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(1148, 42);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(133, 32);
            btnExcel.TabIndex = 9;
            btnExcel.Text = "Xuất Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click_1;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(840, 42);
            btnViewHistory.Margin = new Padding(4);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(140, 32);
            btnViewHistory.TabIndex = 8;
            btnViewHistory.Text = "Xem lịch sử";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click_1;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(0, 15, 0, 15);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewHistory.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewHistory.Location = new Point(29, 108);
            dataGridViewHistory.Margin = new Padding(4);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHistory.Size = new Size(1252, 500);
            dataGridViewHistory.TabIndex = 7;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(532, 45);
            dateTimePickerTo.Margin = new Padding(4);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(284, 29);
            dateTimePickerTo.TabIndex = 6;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(207, 45);
            dateTimePickerFrom.Margin = new Padding(4);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(284, 29);
            dateTimePickerFrom.TabIndex = 5;
            // 
            // HistoryScan
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 673);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "HistoryScan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HistoryScan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblProgressPercentage;
        private ProgressBar progressBarExport;
        private Button btnExcel;
        private Button btnViewHistory;
        private DataGridView dataGridViewHistory;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private Button btnSearch;
        private TextBox textBoxSearch;
        private Label label1;
    }
}