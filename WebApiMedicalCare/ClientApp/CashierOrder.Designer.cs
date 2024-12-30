namespace ClientApp
{
    partial class CashierOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_tieude = new System.Windows.Forms.Label();
            this.dataGridView_Available_products = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.lb_Quantity = new System.Windows.Forms.Label();
            this.lb_oders_regPrice = new System.Windows.Forms.Label();
            this.lb_regular = new System.Windows.Forms.Label();
            this.lb_order_prodName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ProducstID = new System.Windows.Forms.ComboBox();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.lb_Category = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_receipt = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_change_price = new System.Windows.Forms.Label();
            this.lb_change = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_Total_Price = new System.Windows.Forms.Label();
            this.lb_All_Oders = new System.Windows.Forms.Label();
            this.dataGridView_All_Oders = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Available_products)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All_Oders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_tieude);
            this.panel1.Controls.Add(this.dataGridView_Available_products);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(18, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 412);
            this.panel1.TabIndex = 0;
            // 
            // lb_tieude
            // 
            this.lb_tieude.AutoSize = true;
            this.lb_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tieude.Location = new System.Drawing.Point(9, 12);
            this.lb_tieude.Name = "lb_tieude";
            this.lb_tieude.Size = new System.Drawing.Size(198, 29);
            this.lb_tieude.TabIndex = 7;
            this.lb_tieude.Text = "Available product";
            // 
            // dataGridView_Available_products
            // 
            this.dataGridView_Available_products.AllowUserToAddRows = false;
            this.dataGridView_Available_products.AllowUserToDeleteRows = false;
            this.dataGridView_Available_products.ColumnHeadersHeight = 34;
            this.dataGridView_Available_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Available_products.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Available_products.EnableHeadersVisualStyles = false;
            this.dataGridView_Available_products.Location = new System.Drawing.Point(14, 48);
            this.dataGridView_Available_products.Name = "dataGridView_Available_products";
            this.dataGridView_Available_products.ReadOnly = true;
            this.dataGridView_Available_products.RowHeadersVisible = false;
            this.dataGridView_Available_products.RowHeadersWidth = 62;
            this.dataGridView_Available_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Available_products.RowTemplate.Height = 28;
            this.dataGridView_Available_products.Size = new System.Drawing.Size(907, 349);
            this.dataGridView_Available_products.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(961, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 853);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.numericUpDown_quantity);
            this.panel2.Controls.Add(this.lb_Quantity);
            this.panel2.Controls.Add(this.lb_oders_regPrice);
            this.panel2.Controls.Add(this.lb_regular);
            this.panel2.Controls.Add(this.lb_order_prodName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox_ProducstID);
            this.panel2.Controls.Add(this.lb_ProductID);
            this.panel2.Controls.Add(this.comboBox_Category);
            this.panel2.Controls.Add(this.lb_Category);
            this.panel2.Location = new System.Drawing.Point(18, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 420);
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
            this.btn_clear.Location = new System.Drawing.Point(418, 290);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(503, 61);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
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
            this.btn_Add.Location = new System.Drawing.Point(418, 199);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(503, 61);
            this.btn_Add.TabIndex = 25;
            this.btn_Add.Text = "ADD ORDER";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDown_quantity.Location = new System.Drawing.Point(647, 50);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(272, 35);
            this.numericUpDown_quantity.TabIndex = 24;
            // 
            // lb_Quantity
            // 
            this.lb_Quantity.AutoSize = true;
            this.lb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Quantity.Location = new System.Drawing.Point(543, 50);
            this.lb_Quantity.Name = "lb_Quantity";
            this.lb_Quantity.Size = new System.Drawing.Size(100, 29);
            this.lb_Quantity.TabIndex = 23;
            this.lb_Quantity.Text = "Quantity";
            // 
            // lb_oders_regPrice
            // 
            this.lb_oders_regPrice.AutoSize = true;
            this.lb_oders_regPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_oders_regPrice.Location = new System.Drawing.Point(203, 272);
            this.lb_oders_regPrice.Name = "lb_oders_regPrice";
            this.lb_oders_regPrice.Size = new System.Drawing.Size(71, 29);
            this.lb_oders_regPrice.TabIndex = 22;
            this.lb_oders_regPrice.Text = "$0.00";
            // 
            // lb_regular
            // 
            this.lb_regular.AutoSize = true;
            this.lb_regular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_regular.Location = new System.Drawing.Point(22, 272);
            this.lb_regular.Name = "lb_regular";
            this.lb_regular.Size = new System.Drawing.Size(150, 29);
            this.lb_regular.TabIndex = 21;
            this.lb_regular.Text = "Regular rice:";
            // 
            // lb_order_prodName
            // 
            this.lb_order_prodName.AutoSize = true;
            this.lb_order_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_order_prodName.Location = new System.Drawing.Point(203, 220);
            this.lb_order_prodName.Name = "lb_order_prodName";
            this.lb_order_prodName.Size = new System.Drawing.Size(53, 29);
            this.lb_order_prodName.TabIndex = 20;
            this.lb_order_prodName.Text = "-----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product Name:";
            // 
            // comboBox_ProducstID
            // 
            this.comboBox_ProducstID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_ProducstID.FormattingEnabled = true;
            this.comboBox_ProducstID.Location = new System.Drawing.Point(147, 106);
            this.comboBox_ProducstID.Name = "comboBox_ProducstID";
            this.comboBox_ProducstID.Size = new System.Drawing.Size(366, 37);
            this.comboBox_ProducstID.TabIndex = 18;
            this.comboBox_ProducstID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProducstID_SelectedIndexChanged);
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ProductID.Location = new System.Drawing.Point(22, 114);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(125, 29);
            this.lb_ProductID.TabIndex = 17;
            this.lb_ProductID.Text = "Product ID";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(147, 36);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(366, 37);
            this.comboBox_Category.TabIndex = 16;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // lb_Category
            // 
            this.lb_Category.AutoSize = true;
            this.lb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Category.Location = new System.Drawing.Point(22, 44);
            this.lb_Category.Name = "lb_Category";
            this.lb_Category.Size = new System.Drawing.Size(110, 29);
            this.lb_Category.TabIndex = 15;
            this.lb_Category.Text = "Category";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btn_remove);
            this.panel4.Controls.Add(this.btn_receipt);
            this.panel4.Controls.Add(this.btn_pay);
            this.panel4.Controls.Add(this.txt_Amount);
            this.panel4.Controls.Add(this.lb_amount);
            this.panel4.Controls.Add(this.lb_change_price);
            this.panel4.Controls.Add(this.lb_change);
            this.panel4.Controls.Add(this.lb_price);
            this.panel4.Controls.Add(this.lb_Total_Price);
            this.panel4.Controls.Add(this.lb_All_Oders);
            this.panel4.Controls.Add(this.dataGridView_All_Oders);
            this.panel4.Location = new System.Drawing.Point(982, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(517, 850);
            this.panel4.TabIndex = 2;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(28, 771);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(461, 61);
            this.btn_remove.TabIndex = 31;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_receipt
            // 
            this.btn_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_receipt.FlatAppearance.BorderSize = 0;
            this.btn_receipt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_receipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_receipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_receipt.ForeColor = System.Drawing.Color.White;
            this.btn_receipt.Location = new System.Drawing.Point(28, 689);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.Size = new System.Drawing.Size(461, 61);
            this.btn_receipt.TabIndex = 30;
            this.btn_receipt.Text = "RECEIPT";
            this.btn_receipt.UseVisualStyleBackColor = false;
            this.btn_receipt.Click += new System.EventHandler(this.btn_receipt_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.btn_pay.FlatAppearance.BorderSize = 0;
            this.btn_pay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_pay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_pay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(176)))), ((int)(((byte)(161)))));
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.Location = new System.Drawing.Point(28, 607);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(461, 61);
            this.btn_pay.TabIndex = 29;
            this.btn_pay.Text = "PAY";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Amount.Location = new System.Drawing.Point(183, 483);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(186, 35);
            this.txt_Amount.TabIndex = 28;
            this.txt_Amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Amount_KeyDown);
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_amount.Location = new System.Drawing.Point(37, 486);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(94, 29);
            this.lb_amount.TabIndex = 27;
            this.lb_amount.Text = "Amount";
            // 
            // lb_change_price
            // 
            this.lb_change_price.AutoSize = true;
            this.lb_change_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_change_price.Location = new System.Drawing.Point(183, 549);
            this.lb_change_price.Name = "lb_change_price";
            this.lb_change_price.Size = new System.Drawing.Size(71, 29);
            this.lb_change_price.TabIndex = 26;
            this.lb_change_price.Text = "$0.00";
            // 
            // lb_change
            // 
            this.lb_change.AutoSize = true;
            this.lb_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_change.Location = new System.Drawing.Point(37, 549);
            this.lb_change.Name = "lb_change";
            this.lb_change.Size = new System.Drawing.Size(97, 29);
            this.lb_change.TabIndex = 25;
            this.lb_change.Text = "Change";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_price.Location = new System.Drawing.Point(183, 423);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(71, 29);
            this.lb_price.TabIndex = 24;
            this.lb_price.Text = "$0.00";
            // 
            // lb_Total_Price
            // 
            this.lb_Total_Price.AutoSize = true;
            this.lb_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Total_Price.Location = new System.Drawing.Point(37, 423);
            this.lb_Total_Price.Name = "lb_Total_Price";
            this.lb_Total_Price.Size = new System.Drawing.Size(136, 29);
            this.lb_Total_Price.TabIndex = 23;
            this.lb_Total_Price.Text = "Total Price:";
            // 
            // lb_All_Oders
            // 
            this.lb_All_Oders.AutoSize = true;
            this.lb_All_Oders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_All_Oders.Location = new System.Drawing.Point(23, 12);
            this.lb_All_Oders.Name = "lb_All_Oders";
            this.lb_All_Oders.Size = new System.Drawing.Size(121, 29);
            this.lb_All_Oders.TabIndex = 8;
            this.lb_All_Oders.Text = "All Orders";
            this.lb_All_Oders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_All_Oders
            // 
            this.dataGridView_All_Oders.AllowUserToAddRows = false;
            this.dataGridView_All_Oders.AllowUserToDeleteRows = false;
            this.dataGridView_All_Oders.ColumnHeadersHeight = 34;
            this.dataGridView_All_Oders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_All_Oders.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_All_Oders.EnableHeadersVisualStyles = false;
            this.dataGridView_All_Oders.Location = new System.Drawing.Point(28, 48);
            this.dataGridView_All_Oders.Name = "dataGridView_All_Oders";
            this.dataGridView_All_Oders.ReadOnly = true;
            this.dataGridView_All_Oders.RowHeadersVisible = false;
            this.dataGridView_All_Oders.RowHeadersWidth = 62;
            this.dataGridView_All_Oders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_All_Oders.RowTemplate.Height = 28;
            this.dataGridView_All_Oders.Size = new System.Drawing.Size(470, 349);
            this.dataGridView_All_Oders.TabIndex = 7;
            this.dataGridView_All_Oders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_All_Oders_CellClick);
            this.dataGridView_All_Oders.Click += new System.EventHandler(this.dataGridView_All_Oders_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            //this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CashierOderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOderControl";
            this.Size = new System.Drawing.Size(1542, 915);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Available_products)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All_Oders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_Available_products;
        private System.Windows.Forms.Label lb_tieude;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Label lb_Category;
        private System.Windows.Forms.ComboBox comboBox_ProducstID;
        private System.Windows.Forms.Label lb_ProductID;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Label lb_Quantity;
        private System.Windows.Forms.Label lb_oders_regPrice;
        private System.Windows.Forms.Label lb_regular;
        private System.Windows.Forms.Label lb_order_prodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.Label lb_change_price;
        private System.Windows.Forms.Label lb_change;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_Total_Price;
        private System.Windows.Forms.Label lb_All_Oders;
        private System.Windows.Forms.DataGridView dataGridView_All_Oders;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_receipt;
        private System.Windows.Forms.Button btn_pay;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}