namespace CometBarCode
{
    partial class Login
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
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            chkRememberMe = new CheckBox();
            btnClose = new Button();
            txtPassword = new TextBox();
            btnLogin = new Button();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lbconnect = new Label();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture2;
            pictureBox2.Location = new Point(208, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkRememberMe);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(91, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 191);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkRememberMe.ForeColor = Color.Black;
            chkRememberMe.Location = new Point(159, 99);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(100, 23);
            chkRememberMe.TabIndex = 9;
            chkRememberMe.Text = "Remember ";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkRed;
            btnClose.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(244, 128);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(69, 37);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(159, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(154, 26);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(159, 128);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 37);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(159, 31);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(154, 26);
            txtUsername.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(51, 66);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 6;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(42, 33);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 5;
            label2.Text = "User Name :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbconnect);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(7, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 447);
            panel1.TabIndex = 12;
            // 
            // lbconnect
            // 
            lbconnect.AutoSize = true;
            lbconnect.Location = new Point(224, 377);
            lbconnect.Name = "lbconnect";
            lbconnect.Size = new Size(102, 19);
            lbconnect.TabIndex = 13;
            lbconnect.Text = "Đang kết nối ...";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(91, 342);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(391, 23);
            progressBar.TabIndex = 12;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(598, 463);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbconnect;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}