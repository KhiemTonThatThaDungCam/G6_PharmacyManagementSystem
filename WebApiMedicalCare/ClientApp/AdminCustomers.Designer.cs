namespace ClientApp
{
    partial class AdminCustomers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_tieude = new System.Windows.Forms.Label();
            this.dataGridView_AllCustomers = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView_AllCustomers);
            this.panel1.Controls.Add(this.lb_tieude);
            this.panel1.Location = new System.Drawing.Point(19, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 865);
            this.panel1.TabIndex = 9;
            // 
            // lb_tieude
            // 
            this.lb_tieude.AutoSize = true;
            this.lb_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tieude.Location = new System.Drawing.Point(12, 14);
            this.lb_tieude.Name = "lb_tieude";
            this.lb_tieude.Size = new System.Drawing.Size(157, 29);
            this.lb_tieude.TabIndex = 8;
            this.lb_tieude.Text = "All customers";
            // 
            // dataGridView_AllCustomers
            // 
            this.dataGridView_AllCustomers.AllowUserToAddRows = false;
            this.dataGridView_AllCustomers.AllowUserToDeleteRows = false;
            this.dataGridView_AllCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AllCustomers.ColumnHeadersHeight = 34;
            this.dataGridView_AllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_AllCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_AllCustomers.EnableHeadersVisualStyles = false;
            this.dataGridView_AllCustomers.Location = new System.Drawing.Point(17, 55);
            this.dataGridView_AllCustomers.Name = "dataGridView_AllCustomers";
            this.dataGridView_AllCustomers.ReadOnly = true;
            this.dataGridView_AllCustomers.RowHeadersVisible = false;
            this.dataGridView_AllCustomers.RowHeadersWidth = 62;
            this.dataGridView_AllCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_AllCustomers.RowTemplate.Height = 28;
            this.dataGridView_AllCustomers.Size = new System.Drawing.Size(1447, 781);
            this.dataGridView_AllCustomers.TabIndex = 9;
            // 
            // adminCustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "adminCustomersControl";
            this.Size = new System.Drawing.Size(1537, 915);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_tieude;
        private System.Windows.Forms.DataGridView dataGridView_AllCustomers;
    }
}