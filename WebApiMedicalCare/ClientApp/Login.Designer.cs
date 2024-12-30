namespace ClientApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_slogan2 = new System.Windows.Forms.Label();
            this.lb_slogan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Thoat = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox_ShowPass = new System.Windows.Forms.CheckBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.lb_question = new System.Windows.Forms.Label();
            this.linkLabel_forgotPass = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.lb_slogan2);
            this.panel1.Controls.Add(this.lb_slogan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 558);
            this.panel1.TabIndex = 0;
            // 
            // lb_slogan2
            // 
            this.lb_slogan2.AutoSize = true;
            this.lb_slogan2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_slogan2.Location = new System.Drawing.Point(4, 305);
            this.lb_slogan2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_slogan2.Name = "lb_slogan2";
            this.lb_slogan2.Size = new System.Drawing.Size(218, 39);
            this.lb_slogan2.TabIndex = 9;
            this.lb_slogan2.Text = "Our mission";
            // 
            // lb_slogan
            // 
            this.lb_slogan.AutoSize = true;
            this.lb_slogan.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_slogan.Location = new System.Drawing.Point(4, 266);
            this.lb_slogan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_slogan.Name = "lb_slogan";
            this.lb_slogan.Size = new System.Drawing.Size(217, 39);
            this.lb_slogan.TabIndex = 8;
            this.lb_slogan.Text = "Your health";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClientApp.Properties.Resources.healthcare;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Thoat
            // 
            this.lb_Thoat.AutoSize = true;
            this.lb_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Thoat.Location = new System.Drawing.Point(684, 0);
            this.lb_Thoat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Thoat.Name = "lb_Thoat";
            this.lb_Thoat.Size = new System.Drawing.Size(26, 25);
            this.lb_Thoat.TabIndex = 1;
            this.lb_Thoat.Text = "X";
            this.lb_Thoat.Click += new System.EventHandler(this.lb_Thoat_Click);
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_username.Location = new System.Drawing.Point(251, 173);
            this.lb_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(102, 25);
            this.lb_username.TabIndex = 2;
            this.lb_username.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_username.Location = new System.Drawing.Point(251, 198);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(435, 30);
            this.txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_password.Location = new System.Drawing.Point(251, 278);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(435, 30);
            this.txt_password.TabIndex = 5;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_password.Location = new System.Drawing.Point(251, 253);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(98, 25);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_SignIn.FlatAppearance.BorderSize = 0;
            this.btn_SignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_SignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SignIn.ForeColor = System.Drawing.Color.White;
            this.btn_SignIn.Location = new System.Drawing.Point(251, 390);
            this.btn_SignIn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(434, 44);
            this.btn_SignIn.TabIndex = 6;
            this.btn_SignIn.Text = "Sign In";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ClientApp.Properties.Resources.BaBacSi;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(364, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 150);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox_ShowPass
            // 
            this.checkBox_ShowPass.AutoSize = true;
            this.checkBox_ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox_ShowPass.Location = new System.Drawing.Point(251, 324);
            this.checkBox_ShowPass.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_ShowPass.Name = "checkBox_ShowPass";
            this.checkBox_ShowPass.Size = new System.Drawing.Size(84, 29);
            this.checkBox_ShowPass.TabIndex = 8;
            this.checkBox_ShowPass.Text = "Show";
            this.checkBox_ShowPass.UseVisualStyleBackColor = true;
            this.checkBox_ShowPass.CheckedChanged += new System.EventHandler(this.checkBox_ShowPass_CheckedChanged);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(251, 486);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(434, 44);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lb_question
            // 
            this.lb_question.AutoSize = true;
            this.lb_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_question.Location = new System.Drawing.Point(251, 461);
            this.lb_question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(206, 25);
            this.lb_question.TabIndex = 10;
            this.lb_question.Text = "Have no account yet ?";
            // 
            // linkLabel_forgotPass
            // 
            this.linkLabel_forgotPass.AutoSize = true;
            this.linkLabel_forgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel_forgotPass.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_forgotPass.Location = new System.Drawing.Point(493, 327);
            this.linkLabel_forgotPass.Name = "linkLabel_forgotPass";
            this.linkLabel_forgotPass.Size = new System.Drawing.Size(175, 25);
            this.linkLabel_forgotPass.TabIndex = 11;
            this.linkLabel_forgotPass.TabStop = true;
            this.linkLabel_forgotPass.Text = "Forgot Password ?";
            this.linkLabel_forgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forgotPass_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 558);
            this.Controls.Add(this.linkLabel_forgotPass);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.checkBox_ShowPass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_Thoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Thoat;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_slogan2;
        private System.Windows.Forms.Label lb_slogan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox_ShowPass;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lb_question;
        private System.Windows.Forms.LinkLabel linkLabel_forgotPass;
    }
}