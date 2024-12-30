namespace ClientApp
{
    partial class AdminAddProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.lb_tieude = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.panel_picture = new System.Windows.Forms.Panel();
            this.pictureBox_product = new System.Windows.Forms.PictureBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.lb_Category = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.lb_stock = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lb_Price = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.txt_productID = new System.Windows.Forms.TextBox();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_products);
            this.panel1.Controls.Add(this.lb_tieude);
            this.panel1.Location = new System.Drawing.Point(21, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1496, 463);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.AllowUserToAddRows = false;
            this.dataGridView_products.AllowUserToDeleteRows = false;
            this.dataGridView_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_products.ColumnHeadersHeight = 34;
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_products.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_products.EnableHeadersVisualStyles = false;
            this.dataGridView_products.Location = new System.Drawing.Point(17, 48);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.ReadOnly = true;
            this.dataGridView_products.RowHeadersVisible = false;
            this.dataGridView_products.RowHeadersWidth = 62;
            this.dataGridView_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_products.RowTemplate.Height = 28;
            this.dataGridView_products.Size = new System.Drawing.Size(1460, 400);
            this.dataGridView_products.TabIndex = 5;
            this.dataGridView_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_products_CellClick);
            // 
            // lb_tieude
            // 
            this.lb_tieude.AutoSize = true;
            this.lb_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tieude.Location = new System.Drawing.Point(12, 16);
            this.lb_tieude.Name = "lb_tieude";
            this.lb_tieude.Size = new System.Drawing.Size(96, 29);
            this.lb_tieude.TabIndex = 0;
            this.lb_tieude.Text = "Product";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.btn_import);
            this.panel2.Controls.Add(this.panel_picture);
            this.panel2.Controls.Add(this.comboBox_status);
            this.panel2.Controls.Add(this.lb_status);
            this.panel2.Controls.Add(this.comboBox_Category);
            this.panel2.Controls.Add(this.lb_Category);
            this.panel2.Controls.Add(this.txt_stock);
            this.panel2.Controls.Add(this.lb_stock);
            this.panel2.Controls.Add(this.txt_price);
            this.panel2.Controls.Add(this.lb_Price);
            this.panel2.Controls.Add(this.txt_ProductName);
            this.panel2.Controls.Add(this.lb_ProductName);
            this.panel2.Controls.Add(this.txt_productID);
            this.panel2.Controls.Add(this.lb_ProductID);
            this.panel2.Location = new System.Drawing.Point(21, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1496, 378);
            this.panel2.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(941, 260);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(200, 61);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(656, 260);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(200, 61);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(371, 260);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(200, 61);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(86, 260);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(200, 61);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_import.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_import.FlatAppearance.BorderSize = 0;
            this.btn_import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Location = new System.Drawing.Point(1289, 175);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(145, 43);
            this.btn_import.TabIndex = 18;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // panel_picture
            // 
            this.panel_picture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_picture.Controls.Add(this.pictureBox_product);
            this.panel_picture.Location = new System.Drawing.Point(1289, 17);
            this.panel_picture.Name = "panel_picture";
            this.panel_picture.Size = new System.Drawing.Size(145, 150);
            this.panel_picture.TabIndex = 17;
            // 
            // pictureBox_product
            // 
            this.pictureBox_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_product.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_product.Name = "pictureBox_product";
            this.pictureBox_product.Size = new System.Drawing.Size(145, 150);
            this.pictureBox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_product.TabIndex = 0;
            this.pictureBox_product.TabStop = false;
            // 
            // comboBox_status
            // 
            this.comboBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox_status.Location = new System.Drawing.Point(788, 153);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(354, 34);
            this.comboBox_status.TabIndex = 16;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_status.Location = new System.Drawing.Point(694, 161);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(68, 25);
            this.lb_status.TabIndex = 15;
            this.lb_status.Text = "Status";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(223, 153);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(354, 34);
            this.comboBox_Category.TabIndex = 14;
            // 
            // lb_Category
            // 
            this.lb_Category.AutoSize = true;
            this.lb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Category.Location = new System.Drawing.Point(125, 157);
            this.lb_Category.Name = "lb_Category";
            this.lb_Category.Size = new System.Drawing.Size(92, 25);
            this.lb_Category.TabIndex = 10;
            this.lb_Category.Text = "Category";
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_stock.Location = new System.Drawing.Point(788, 100);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(354, 32);
            this.txt_stock.TabIndex = 9;
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_stock.Location = new System.Drawing.Point(694, 106);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(62, 25);
            this.lb_stock.TabIndex = 8;
            this.lb_stock.Text = "Stock";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_price.Location = new System.Drawing.Point(788, 47);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(354, 32);
            this.txt_price.TabIndex = 7;
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Price.Location = new System.Drawing.Point(694, 51);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(86, 25);
            this.lb_Price.TabIndex = 6;
            this.lb_Price.Text = "Price ($)";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_ProductName.Location = new System.Drawing.Point(223, 100);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(354, 32);
            this.txt_ProductName.TabIndex = 5;
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ProductName.Location = new System.Drawing.Point(81, 104);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(136, 25);
            this.lb_ProductName.TabIndex = 4;
            this.lb_ProductName.Text = "Product Name";
            // 
            // txt_productID
            // 
            this.txt_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_productID.Location = new System.Drawing.Point(223, 47);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.Size = new System.Drawing.Size(354, 32);
            this.txt_productID.TabIndex = 1;
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ProductID.Location = new System.Drawing.Point(114, 51);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(103, 25);
            this.lb_ProductID.TabIndex = 0;
            this.lb_ProductID.Text = "Product ID";
            // 
            // adminAddProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminAddProductsControl";
            this.Size = new System.Drawing.Size(1537, 915);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_tieude;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Label lb_Category;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.TextBox txt_productID;
        private System.Windows.Forms.Label lb_ProductID;
        private System.Windows.Forms.Panel panel_picture;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.PictureBox pictureBox_product;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView_products;
    }
}