namespace ClientApp
{
    partial class AdminAddCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_CategoryData = new System.Windows.Forms.DataGridView();
            this.lb_CategoryData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear_Category = new System.Windows.Forms.Button();
            this.btn_update_Category = new System.Windows.Forms.Button();
            this.btn_delete_Category = new System.Windows.Forms.Button();
            this.btn_Add_Category = new System.Windows.Forms.Button();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.lb_category = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CategoryData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView_CategoryData);
            this.panel2.Controls.Add(this.lb_CategoryData);
            this.panel2.Location = new System.Drawing.Point(495, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 694);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView_CategoryData
            // 
            this.dataGridView_CategoryData.AllowUserToAddRows = false;
            this.dataGridView_CategoryData.AllowUserToDeleteRows = false;
            this.dataGridView_CategoryData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CategoryData.ColumnHeadersHeight = 34;
            this.dataGridView_CategoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_CategoryData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_CategoryData.EnableHeadersVisualStyles = false;
            this.dataGridView_CategoryData.Location = new System.Drawing.Point(18, 54);
            this.dataGridView_CategoryData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_CategoryData.Name = "dataGridView_CategoryData";
            this.dataGridView_CategoryData.ReadOnly = true;
            this.dataGridView_CategoryData.RowHeadersVisible = false;
            this.dataGridView_CategoryData.RowHeadersWidth = 62;
            this.dataGridView_CategoryData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_CategoryData.RowTemplate.Height = 28;
            this.dataGridView_CategoryData.Size = new System.Drawing.Size(813, 624);
            this.dataGridView_CategoryData.TabIndex = 4;
            this.dataGridView_CategoryData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CategoryData_CellClick);
            // 
            // lb_CategoryData
            // 
            this.lb_CategoryData.AutoSize = true;
            this.lb_CategoryData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_CategoryData.Location = new System.Drawing.Point(13, 28);
            this.lb_CategoryData.Name = "lb_CategoryData";
            this.lb_CategoryData.Size = new System.Drawing.Size(152, 25);
            this.lb_CategoryData.TabIndex = 3;
            this.lb_CategoryData.Text = "Category\'s Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_clear_Category);
            this.panel1.Controls.Add(this.btn_update_Category);
            this.panel1.Controls.Add(this.btn_delete_Category);
            this.panel1.Controls.Add(this.btn_Add_Category);
            this.panel1.Controls.Add(this.comboBox_status);
            this.panel1.Controls.Add(this.lb_status);
            this.panel1.Controls.Add(this.txt_Category);
            this.panel1.Controls.Add(this.lb_category);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(24, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 694);
            this.panel1.TabIndex = 2;
            // 
            // btn_clear_Category
            // 
            this.btn_clear_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_clear_Category.FlatAppearance.BorderSize = 0;
            this.btn_clear_Category.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_clear_Category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_clear_Category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_clear_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_clear_Category.ForeColor = System.Drawing.Color.White;
            this.btn_clear_Category.Location = new System.Drawing.Point(20, 602);
            this.btn_clear_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_Category.Name = "btn_clear_Category";
            this.btn_clear_Category.Size = new System.Drawing.Size(388, 49);
            this.btn_clear_Category.TabIndex = 14;
            this.btn_clear_Category.Text = "CLEAR";
            this.btn_clear_Category.UseVisualStyleBackColor = false;
            this.btn_clear_Category.Click += new System.EventHandler(this.btn_clear_Category_Click);
            // 
            // btn_update_Category
            // 
            this.btn_update_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_update_Category.FlatAppearance.BorderSize = 0;
            this.btn_update_Category.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_update_Category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_update_Category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_update_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_update_Category.ForeColor = System.Drawing.Color.White;
            this.btn_update_Category.Location = new System.Drawing.Point(20, 519);
            this.btn_update_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update_Category.Name = "btn_update_Category";
            this.btn_update_Category.Size = new System.Drawing.Size(388, 49);
            this.btn_update_Category.TabIndex = 15;
            this.btn_update_Category.Text = "UPDATE";
            this.btn_update_Category.UseVisualStyleBackColor = false;
            this.btn_update_Category.Click += new System.EventHandler(this.btn_update_Category_Click);
            // 
            // btn_delete_Category
            // 
            this.btn_delete_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_delete_Category.FlatAppearance.BorderSize = 0;
            this.btn_delete_Category.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_delete_Category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_delete_Category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_delete_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_delete_Category.ForeColor = System.Drawing.Color.White;
            this.btn_delete_Category.Location = new System.Drawing.Point(20, 437);
            this.btn_delete_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete_Category.Name = "btn_delete_Category";
            this.btn_delete_Category.Size = new System.Drawing.Size(388, 49);
            this.btn_delete_Category.TabIndex = 14;
            this.btn_delete_Category.Text = "DELETE";
            this.btn_delete_Category.UseVisualStyleBackColor = false;
            this.btn_delete_Category.Click += new System.EventHandler(this.btn_delete_Category_Click);
            // 
            // btn_Add_Category
            // 
            this.btn_Add_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_Add_Category.FlatAppearance.BorderSize = 0;
            this.btn_Add_Category.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_Add_Category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_Add_Category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_Add_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Add_Category.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Category.Location = new System.Drawing.Point(20, 354);
            this.btn_Add_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_Category.Name = "btn_Add_Category";
            this.btn_Add_Category.Size = new System.Drawing.Size(388, 49);
            this.btn_Add_Category.TabIndex = 13;
            this.btn_Add_Category.Text = "ADD";
            this.btn_Add_Category.UseVisualStyleBackColor = false;
            this.btn_Add_Category.Click += new System.EventHandler(this.btn_Add_Category_Click);
            // 
            // comboBox_status
            // 
            this.comboBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox_status.Location = new System.Drawing.Point(20, 286);
            this.comboBox_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(388, 33);
            this.comboBox_status.TabIndex = 10;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_status.Location = new System.Drawing.Point(20, 262);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(68, 25);
            this.lb_status.TabIndex = 9;
            this.lb_status.Text = "Status";
            // 
            // txt_Category
            // 
            this.txt_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Category.Location = new System.Drawing.Point(20, 210);
            this.txt_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(388, 30);
            this.txt_Category.TabIndex = 3;
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_category.Location = new System.Drawing.Point(20, 184);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(92, 25);
            this.lb_category.TabIndex = 2;
            this.lb_category.Text = "Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClientApp.Properties.Resources.medicalfolder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(125, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AdminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminAddCategories";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CategoryData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_CategoryData;
        private System.Windows.Forms.Label lb_CategoryData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear_Category;
        private System.Windows.Forms.Button btn_update_Category;
        private System.Windows.Forms.Button btn_delete_Category;
        private System.Windows.Forms.Button btn_Add_Category;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}