using Microsoft.Win32;

namespace ClientApp
{
    partial class Register
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
            this.btn_login = new System.Windows.Forms.Button();
            this.checkBox_ShowPass = new System.Windows.Forms.CheckBox();
            this.btn_SingUp = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_question = new System.Windows.Forms.Label();
            this.checkBox_showconfirm = new System.Windows.Forms.CheckBox();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.lb_confirm_password = new System.Windows.Forms.Label();
            this.lb_Thoat = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(254, 492);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(434, 44);
            this.btn_login.TabIndex = 18;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // checkBox_ShowPass
            // 
            this.checkBox_ShowPass.AutoSize = true;
            this.checkBox_ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox_ShowPass.Location = new System.Drawing.Point(603, 298);
            this.checkBox_ShowPass.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_ShowPass.Name = "checkBox_ShowPass";
            this.checkBox_ShowPass.Size = new System.Drawing.Size(84, 29);
            this.checkBox_ShowPass.TabIndex = 17;
            this.checkBox_ShowPass.Text = "Show";
            this.checkBox_ShowPass.UseVisualStyleBackColor = true;
            this.checkBox_ShowPass.CheckedChanged += new System.EventHandler(this.checkBox_ShowPass_CheckedChanged);
            // 
            // btn_SingUp
            // 
            this.btn_SingUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_SingUp.FlatAppearance.BorderSize = 0;
            this.btn_SingUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_SingUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_SingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SingUp.ForeColor = System.Drawing.Color.White;
            this.btn_SingUp.Location = new System.Drawing.Point(254, 406);
            this.btn_SingUp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SingUp.Name = "btn_SingUp";
            this.btn_SingUp.Size = new System.Drawing.Size(434, 44);
            this.btn_SingUp.TabIndex = 15;
            this.btn_SingUp.Text = "Sign Up";
            this.btn_SingUp.UseVisualStyleBackColor = false;
            this.btn_SingUp.Click += new System.EventHandler(this.btn_SingUp_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_password.Location = new System.Drawing.Point(254, 259);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(435, 30);
            this.txt_password.TabIndex = 14;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_password.Location = new System.Drawing.Point(254, 230);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(98, 25);
            this.lb_password.TabIndex = 13;
            this.lb_password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_username.Location = new System.Drawing.Point(254, 134);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(435, 30);
            this.txt_username.TabIndex = 12;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_username.Location = new System.Drawing.Point(254, 106);
            this.lb_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(102, 25);
            this.lb_username.TabIndex = 11;
            this.lb_username.Text = "Username";
            // 
            // lb_question
            // 
            this.lb_question.AutoSize = true;
            this.lb_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_question.Location = new System.Drawing.Point(250, 466);
            this.lb_question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(244, 25);
            this.lb_question.TabIndex = 19;
            this.lb_question.Text = "Already have an account ?";
            // 
            // checkBox_showconfirm
            // 
            this.checkBox_showconfirm.AutoSize = true;
            this.checkBox_showconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox_showconfirm.Location = new System.Drawing.Point(603, 368);
            this.checkBox_showconfirm.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_showconfirm.Name = "checkBox_showconfirm";
            this.checkBox_showconfirm.Size = new System.Drawing.Size(84, 29);
            this.checkBox_showconfirm.TabIndex = 22;
            this.checkBox_showconfirm.Text = "Show";
            this.checkBox_showconfirm.UseVisualStyleBackColor = true;
            this.checkBox_showconfirm.CheckedChanged += new System.EventHandler(this.checkBox_showconfirm_CheckedChanged);
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_confirmPass.Location = new System.Drawing.Point(254, 332);
            this.txt_confirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.PasswordChar = '●';
            this.txt_confirmPass.Size = new System.Drawing.Size(435, 30);
            this.txt_confirmPass.TabIndex = 21;
            // 
            // lb_confirm_password
            // 
            this.lb_confirm_password.AutoSize = true;
            this.lb_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_confirm_password.Location = new System.Drawing.Point(254, 303);
            this.lb_confirm_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_confirm_password.Name = "lb_confirm_password";
            this.lb_confirm_password.Size = new System.Drawing.Size(169, 25);
            this.lb_confirm_password.TabIndex = 20;
            this.lb_confirm_password.Text = "Confirm password";
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
            this.lb_Thoat.TabIndex = 23;
            this.lb_Thoat.Text = "X";
            this.lb_Thoat.Click += new System.EventHandler(this.lb_Thoat_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_email.Location = new System.Drawing.Point(254, 197);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(435, 30);
            this.txt_email.TabIndex = 25;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_email.Location = new System.Drawing.Point(254, 168);
            this.lb_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(60, 25);
            this.lb_email.TabIndex = 24;
            this.lb_email.Text = "Email";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ClientApp.Properties.Resources.BaBacSi;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(392, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 109);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClientApp.Properties.Resources.healthcare;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 165);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 558);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_Thoat);
            this.Controls.Add(this.checkBox_showconfirm);
            this.Controls.Add(this.txt_confirmPass);
            this.Controls.Add(this.lb_confirm_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.checkBox_ShowPass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_SingUp);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_question);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_slogan2;
        private System.Windows.Forms.Label lb_slogan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox checkBox_ShowPass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_SingUp;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_question;
        private System.Windows.Forms.CheckBox checkBox_showconfirm;
        private System.Windows.Forms.TextBox txt_confirmPass;
        private System.Windows.Forms.Label lb_confirm_password;
        private System.Windows.Forms.Label lb_Thoat;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_email;
    }
}