namespace CometBarCode
{
    partial class AccountForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnLoadAccount = new Button();
            btnDeleteAccount = new Button();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCreateAccount = new Button();
            cbRole = new ComboBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            panel2 = new Panel();
            listAccount = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listAccount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLoadAccount);
            panel1.Controls.Add(btnDeleteAccount);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 503);
            panel1.TabIndex = 0;
            // 
            // btnLoadAccount
            // 
            btnLoadAccount.BackColor = SystemColors.ActiveCaption;
            btnLoadAccount.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadAccount.Location = new Point(33, 18);
            btnLoadAccount.Name = "btnLoadAccount";
            btnLoadAccount.Size = new Size(139, 36);
            btnLoadAccount.TabIndex = 3;
            btnLoadAccount.Text = "Tải dữ liệu";
            btnLoadAccount.UseVisualStyleBackColor = false;
            btnLoadAccount.Click += btnLoadAccount_Click_2;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.Red;
            btnDeleteAccount.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteAccount.Location = new Point(224, 18);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(142, 36);
            btnDeleteAccount.TabIndex = 2;
            btnDeleteAccount.Text = "Xóa tài khoản";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnCreateAccount);
            panel3.Controls.Add(cbRole);
            panel3.Controls.Add(txtConfirmPassword);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtUsername);
            panel3.Location = new Point(727, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 394);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 240);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 8;
            label4.Text = "Loại tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 165);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 7;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 93);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 5;
            label1.Text = "Tên tài khoản";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.SpringGreen;
            btnCreateAccount.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = SystemColors.ControlText;
            btnCreateAccount.Location = new Point(24, 321);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(293, 47);
            btnCreateAccount.TabIndex = 4;
            btnCreateAccount.Text = "Tạo";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // cbRole
            // 
            cbRole.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(24, 268);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(293, 29);
            cbRole.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(24, 193);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(293, 29);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(24, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(293, 29);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(24, 51);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(293, 29);
            txtUsername.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(listAccount);
            panel2.Location = new Point(33, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(654, 394);
            panel2.TabIndex = 0;
            // 
            // listAccount
            // 
            listAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            listAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            listAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            listAccount.DefaultCellStyle = dataGridViewCellStyle2;
            listAccount.Location = new Point(0, 3);
            listAccount.Name = "listAccount";
            listAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listAccount.Size = new Size(651, 388);
            listAccount.TabIndex = 0;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 527);
            Controls.Add(panel1);
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDeleteAccount;
        private Panel panel3;
        private Label label1;
        private Button btnCreateAccount;
        private ComboBox cbRole;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Panel panel2;
        private DataGridView listAccount;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnLoadAccount;
    }
}