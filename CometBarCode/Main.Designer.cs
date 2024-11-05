namespace CometBarCode
{
    partial class Main
    {
        /// 
        /// Required designer variable.
        /// 
        private System.ComponentModel.IContainer components = null;

        /// 
        /// Clean up any resources being used.
        /// 
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

        /// 
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// 
        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            btnRserror = new Button();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnScan = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBoxBarcode = new PictureBox();
            groupBox4 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            button2 = new Button();
            btnQrcode = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button5 = new Button();
            btnTotall = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            button9 = new Button();
            btnOK = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            button7 = new Button();
            btnDuplicate = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            button3 = new Button();
            btnWrongType = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtProductType = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnSettingQr = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnResetQr = new Button();
            panelResulVisioncheck = new Panel();
            lblResultVisionCheck = new Label();
            groupBox7 = new GroupBox();
            listViewQRcode = new ListView();
            ProcessBar = new ProgressBar();
            menuStrip1 = new MenuStrip();
            Close = new ToolStripMenuItem();
            History = new ToolStripMenuItem();
            User = new ToolStripMenuItem();
            Config = new ToolStripMenuItem();
            panel2 = new Panel();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarcode).BeginInit();
            groupBox4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panelResulVisioncheck.SuspendLayout();
            groupBox7.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1940, 90);
            panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(btnRserror);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Microsoft Sans Serif", 10F);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(1429, 0);
            groupBox3.Margin = new Padding(12, 3, 4, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(320, 90);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "Status";
            // 
            // btnRserror
            // 
            btnRserror.BackColor = Color.Yellow;
            btnRserror.Font = new Font("Times New Roman", 15.75F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            btnRserror.ForeColor = SystemColors.ControlText;
            btnRserror.ImageAlign = ContentAlignment.MiddleRight;
            btnRserror.ImageKey = "switch_off_48px.png";
            btnRserror.Location = new Point(132, 19);
            btnRserror.Margin = new Padding(0);
            btnRserror.Name = "btnRserror";
            btnRserror.Size = new Size(139, 55);
            btnRserror.TabIndex = 48;
            btnRserror.Text = "ERROR";
            btnRserror.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRserror.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Font = new Font("Microsoft Sans Serif", 10F);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(1104, 0);
            groupBox2.Margin = new Padding(12, 3, 4, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(325, 90);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mode";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnScan);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Microsoft Sans Serif", 10F);
            groupBox1.ForeColor = Color.Black;
            groupBox1.ImeMode = ImeMode.NoControl;
            groupBox1.Location = new Point(88, 0);
            groupBox1.Margin = new Padding(12, 3, 12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1016, 90);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(419, 33);
            label1.Name = "label1";
            label1.Size = new Size(334, 31);
            label1.TabIndex = 49;
            label1.Text = "Phần mềm check QR Code ";
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.Silver;
            btnScan.Font = new Font("Times New Roman", 16F);
            btnScan.ForeColor = SystemColors.ControlText;
            btnScan.ImageAlign = ContentAlignment.MiddleRight;
            btnScan.Location = new Point(18, 24);
            btnScan.Margin = new Padding(0);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(131, 55);
            btnScan.TabIndex = 48;
            btnScan.Text = "SCAN";
            btnScan.TextAlign = ContentAlignment.MiddleLeft;
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.Picture1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.Picture2;
            pictureBox1.Location = new Point(1749, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxBarcode
            // 
            pictureBoxBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxBarcode.Location = new Point(13, 105);
            pictureBoxBarcode.Margin = new Padding(4, 3, 4, 3);
            pictureBoxBarcode.Name = "pictureBoxBarcode";
            pictureBoxBarcode.Size = new Size(1409, 983);
            pictureBoxBarcode.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxBarcode.TabIndex = 3;
            pictureBoxBarcode.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(flowLayoutPanel1);
            groupBox4.Controls.Add(panelResulVisioncheck);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.Silver;
            groupBox4.Location = new Point(1430, 102);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(497, 924);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Product Check Result";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel8);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel7);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel6);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel5);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel3);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel4);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(4, 224);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(489, 518);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.4166679F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.5833359F));
            tableLayoutPanel8.Controls.Add(button2, 0, 0);
            tableLayoutPanel8.Controls.Add(btnQrcode, 1, 0);
            tableLayoutPanel8.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel8.Location = new Point(4, 3);
            tableLayoutPanel8.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(481, 59);
            tableLayoutPanel8.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 20.25F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(5, 4);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(161, 51);
            button2.TabIndex = 0;
            button2.Text = "QrCode : ";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnQrcode
            // 
            btnQrcode.AutoSize = true;
            btnQrcode.BackColor = Color.White;
            btnQrcode.Dock = DockStyle.Fill;
            btnQrcode.FlatStyle = FlatStyle.Popup;
            btnQrcode.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQrcode.ForeColor = Color.Black;
            btnQrcode.Location = new Point(175, 4);
            btnQrcode.Margin = new Padding(4, 3, 4, 3);
            btnQrcode.Name = "btnQrcode";
            btnQrcode.Size = new Size(301, 51);
            btnQrcode.TabIndex = 4;
            btnQrcode.Text = "0";
            btnQrcode.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.2083321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.7916641F));
            tableLayoutPanel2.Controls.Add(button5, 0, 0);
            tableLayoutPanel2.Controls.Add(btnTotall, 1, 0);
            tableLayoutPanel2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(4, 68);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(481, 59);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Dock = DockStyle.Fill;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Times New Roman", 20.25F);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(5, 4);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(160, 51);
            button5.TabIndex = 0;
            button5.Text = "Total : ";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // btnTotall
            // 
            btnTotall.AutoSize = true;
            btnTotall.BackColor = Color.White;
            btnTotall.Dock = DockStyle.Fill;
            btnTotall.FlatStyle = FlatStyle.Popup;
            btnTotall.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTotall.ForeColor = Color.Black;
            btnTotall.Location = new Point(174, 4);
            btnTotall.Margin = new Padding(4, 3, 4, 3);
            btnTotall.Name = "btnTotall";
            btnTotall.Size = new Size(302, 51);
            btnTotall.TabIndex = 4;
            btnTotall.Text = "0";
            btnTotall.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.4166679F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.5833359F));
            tableLayoutPanel7.Controls.Add(button9, 0, 0);
            tableLayoutPanel7.Controls.Add(btnOK, 1, 0);
            tableLayoutPanel7.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel7.Location = new Point(4, 133);
            tableLayoutPanel7.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(481, 59);
            tableLayoutPanel7.TabIndex = 11;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Dock = DockStyle.Fill;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Times New Roman", 20.25F);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(5, 4);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(161, 51);
            button9.TabIndex = 0;
            button9.Text = "OK";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            btnOK.AutoSize = true;
            btnOK.BackColor = Color.White;
            btnOK.Dock = DockStyle.Fill;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.Black;
            btnOK.Location = new Point(175, 4);
            btnOK.Margin = new Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(301, 51);
            btnOK.TabIndex = 4;
            btnOK.Text = "0";
            btnOK.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.8333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.1666641F));
            tableLayoutPanel6.Controls.Add(button7, 0, 0);
            tableLayoutPanel6.Controls.Add(btnDuplicate, 1, 0);
            tableLayoutPanel6.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel6.Location = new Point(4, 198);
            tableLayoutPanel6.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(481, 59);
            tableLayoutPanel6.TabIndex = 10;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Dock = DockStyle.Fill;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Times New Roman", 20.25F);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(5, 4);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(163, 51);
            button7.TabIndex = 0;
            button7.Text = "Mã trùng";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // btnDuplicate
            // 
            btnDuplicate.AutoSize = true;
            btnDuplicate.BackColor = Color.White;
            btnDuplicate.Dock = DockStyle.Fill;
            btnDuplicate.FlatStyle = FlatStyle.Popup;
            btnDuplicate.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDuplicate.ForeColor = Color.Black;
            btnDuplicate.Location = new Point(177, 4);
            btnDuplicate.Margin = new Padding(4, 3, 4, 3);
            btnDuplicate.Name = "btnDuplicate";
            btnDuplicate.Size = new Size(299, 51);
            btnDuplicate.TabIndex = 4;
            btnDuplicate.Text = "0";
            btnDuplicate.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.75F));
            tableLayoutPanel5.Controls.Add(button3, 0, 0);
            tableLayoutPanel5.Controls.Add(btnWrongType, 1, 0);
            tableLayoutPanel5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel5.Location = new Point(4, 263);
            tableLayoutPanel5.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(481, 59);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Times New Roman", 20.25F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(5, 4);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(165, 51);
            button3.TabIndex = 0;
            button3.Text = "Sai phân loại";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnWrongType
            // 
            btnWrongType.AutoSize = true;
            btnWrongType.BackColor = Color.White;
            btnWrongType.Dock = DockStyle.Fill;
            btnWrongType.FlatStyle = FlatStyle.Popup;
            btnWrongType.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWrongType.ForeColor = Color.Black;
            btnWrongType.Location = new Point(179, 4);
            btnWrongType.Margin = new Padding(4, 3, 4, 3);
            btnWrongType.Name = "btnWrongType";
            btnWrongType.Size = new Size(297, 51);
            btnWrongType.TabIndex = 4;
            btnWrongType.Text = "0";
            btnWrongType.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtProductType, 0, 0);
            tableLayoutPanel1.Location = new Point(4, 328);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6129F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3871F));
            tableLayoutPanel1.Size = new Size(481, 60);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtProductType
            // 
            txtProductType.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductType.Location = new Point(4, 4);
            txtProductType.Name = "txtProductType";
            txtProductType.Size = new Size(473, 50);
            txtProductType.TabIndex = 0;
            txtProductType.TextChanged += txtProductType_TextChanged_1;
            txtProductType.KeyPress += txtProductType_KeyPress_1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnSettingQr, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 394);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(482, 59);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // btnSettingQr
            // 
            btnSettingQr.BackColor = Color.Linen;
            tableLayoutPanel3.SetColumnSpan(btnSettingQr, 2);
            btnSettingQr.Dock = DockStyle.Fill;
            btnSettingQr.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettingQr.ForeColor = Color.Green;
            btnSettingQr.Location = new Point(4, 3);
            btnSettingQr.Margin = new Padding(4, 3, 4, 3);
            btnSettingQr.Name = "btnSettingQr";
            btnSettingQr.RightToLeft = RightToLeft.No;
            btnSettingQr.Size = new Size(474, 53);
            btnSettingQr.TabIndex = 7;
            btnSettingQr.Text = "Cài đặt mã sản phẩm";
            btnSettingQr.UseVisualStyleBackColor = false;
            btnSettingQr.Click += btnSettingQr_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnResetQr, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 459);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(477, 59);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // btnResetQr
            // 
            btnResetQr.BackColor = Color.Linen;
            tableLayoutPanel4.SetColumnSpan(btnResetQr, 2);
            btnResetQr.Dock = DockStyle.Fill;
            btnResetQr.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetQr.ForeColor = Color.Red;
            btnResetQr.Location = new Point(4, 3);
            btnResetQr.Margin = new Padding(4, 3, 4, 3);
            btnResetQr.Name = "btnResetQr";
            btnResetQr.RightToLeft = RightToLeft.No;
            btnResetQr.Size = new Size(469, 53);
            btnResetQr.TabIndex = 7;
            btnResetQr.Text = "Reset mã sản phẩm";
            btnResetQr.UseVisualStyleBackColor = false;
            btnResetQr.Click += btnResetQr_Click;
            // 
            // panelResulVisioncheck
            // 
            panelResulVisioncheck.BackColor = Color.Azure;
            panelResulVisioncheck.BorderStyle = BorderStyle.FixedSingle;
            panelResulVisioncheck.Controls.Add(lblResultVisionCheck);
            panelResulVisioncheck.Dock = DockStyle.Top;
            panelResulVisioncheck.Location = new Point(4, 22);
            panelResulVisioncheck.Margin = new Padding(4, 3, 4, 3);
            panelResulVisioncheck.Name = "panelResulVisioncheck";
            panelResulVisioncheck.Size = new Size(489, 202);
            panelResulVisioncheck.TabIndex = 0;
            // 
            // lblResultVisionCheck
            // 
            lblResultVisionCheck.BackColor = Color.White;
            lblResultVisionCheck.Dock = DockStyle.Fill;
            lblResultVisionCheck.Font = new Font("Segoe UI", 57.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultVisionCheck.ForeColor = Color.Lime;
            lblResultVisionCheck.Location = new Point(0, 0);
            lblResultVisionCheck.Margin = new Padding(4, 0, 4, 0);
            lblResultVisionCheck.Name = "lblResultVisionCheck";
            lblResultVisionCheck.Size = new Size(487, 200);
            lblResultVisionCheck.TabIndex = 0;
            lblResultVisionCheck.Text = "Ready";
            lblResultVisionCheck.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(listViewQRcode);
            groupBox7.Controls.Add(ProcessBar);
            groupBox7.Dock = DockStyle.Bottom;
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(4, 745);
            groupBox7.Margin = new Padding(4, 3, 4, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4, 3, 4, 3);
            groupBox7.Size = new Size(489, 176);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Log";
            // 
            // listViewQRcode
            // 
            listViewQRcode.GridLines = true;
            listViewQRcode.Location = new Point(4, 3);
            listViewQRcode.Name = "listViewQRcode";
            listViewQRcode.Size = new Size(478, 144);
            listViewQRcode.TabIndex = 3;
            listViewQRcode.UseCompatibleStateImageBehavior = false;
            listViewQRcode.View = View.Details;
            // 
            // ProcessBar
            // 
            ProcessBar.Dock = DockStyle.Bottom;
            ProcessBar.ForeColor = Color.DarkBlue;
            ProcessBar.Location = new Point(4, 153);
            ProcessBar.Margin = new Padding(4, 3, 4, 3);
            ProcessBar.Name = "ProcessBar";
            ProcessBar.Size = new Size(481, 20);
            ProcessBar.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Close, History, User, Config });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = History;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1940, 68);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Close
            // 
            Close.AccessibleRole = AccessibleRole.ButtonMenu;
            Close.AutoSize = false;
            Close.BackColor = Color.Red;
            Close.Font = new Font("Segoe UI", 14F);
            Close.Margin = new Padding(0, 0, 5, 0);
            Close.Name = "Close";
            Close.RightToLeft = RightToLeft.Yes;
            Close.Size = new Size(90, 35);
            Close.Text = "Close";
            Close.Click += Close_Click;
            // 
            // History
            // 
            History.AutoSize = false;
            History.BackColor = Color.Orange;
            History.Font = new Font("Segoe UI", 14F);
            History.Margin = new Padding(0, 0, 5, 0);
            History.Name = "History";
            History.Size = new Size(90, 35);
            History.Text = "History";
            History.Click += History_Click;
            // 
            // User
            // 
            User.AutoSize = false;
            User.BackColor = Color.Aquamarine;
            User.Font = new Font("Segoe UI", 14F);
            User.Margin = new Padding(0, 0, 5, 0);
            User.Name = "User";
            User.Size = new Size(90, 35);
            User.Text = "User";
            User.Click += User_Click;
            // 
            // Config
            // 
            Config.AutoSize = false;
            Config.BackColor = Color.Lime;
            Config.Font = new Font("Segoe UI", 14F);
            Config.Margin = new Padding(0, 0, 5, 0);
            Config.Name = "Config";
            Config.Size = new Size(85, 35);
            Config.Text = "Config";
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1032);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1940, 68);
            panel2.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1940, 1100);
            ControlBox = false;
            Controls.Add(groupBox4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBoxBarcode);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarcode).EndInit();
            groupBox4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panelResulVisioncheck.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelResulVisioncheck;
        private System.Windows.Forms.Label lblResultVisionCheck;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRserror;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem History;
        private System.Windows.Forms.ToolStripMenuItem User;
        private System.Windows.Forms.ToolStripMenuItem Config;
        private System.Windows.Forms.ProgressBar ProcessBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TextBox txtProductType;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSettingQr;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnResetQr;
        private Button btnTotal;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button3;
        private Button btnWrongType;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button7;
        private Button btnDuplicate;
        private TableLayoutPanel tableLayoutPanel7;
        private Button button9;
        private Button btnOK;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button5;
        private Button btnTotall;
        private ListView listViewQRcode;
        private TableLayoutPanel tableLayoutPanel8;
        private Button button2;
        private Button btnQrcode;
        private Label label1;
    }
}

