namespace EnPlus1stTask
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_create_table = new System.Windows.Forms.TabPage();
            this.tab_add_purchase = new System.Windows.Forms.TabPage();
            this.tab_report = new System.Windows.Forms.TabPage();
            this.btn_create_table = new System.Windows.Forms.Button();
            this.lbl_table_status = new System.Windows.Forms.Label();
            this.dtp_purchase_date = new System.Windows.Forms.DateTimePicker();
            this.lb_products = new System.Windows.Forms.ListBox();
            this.tab_add_product = new System.Windows.Forms.TabPage();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_add_product_name = new System.Windows.Forms.TextBox();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab_create_table.SuspendLayout();
            this.tab_add_purchase.SuspendLayout();
            this.tab_report.SuspendLayout();
            this.tab_add_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_create_table);
            this.tabControl1.Controls.Add(this.tab_add_purchase);
            this.tabControl1.Controls.Add(this.tab_add_product);
            this.tabControl1.Controls.Add(this.tab_report);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_create_table
            // 
            this.tab_create_table.Controls.Add(this.lbl_table_status);
            this.tab_create_table.Controls.Add(this.btn_create_table);
            this.tab_create_table.Location = new System.Drawing.Point(4, 22);
            this.tab_create_table.Name = "tab_create_table";
            this.tab_create_table.Padding = new System.Windows.Forms.Padding(3);
            this.tab_create_table.Size = new System.Drawing.Size(768, 400);
            this.tab_create_table.TabIndex = 0;
            this.tab_create_table.Text = "Создать таблицу";
            this.tab_create_table.UseVisualStyleBackColor = true;
            // 
            // tab_add_purchase
            // 
            this.tab_add_purchase.Controls.Add(this.tb_quantity);
            this.tab_add_purchase.Controls.Add(this.tb_cost);
            this.tab_add_purchase.Controls.Add(this.lb_products);
            this.tab_add_purchase.Controls.Add(this.dtp_purchase_date);
            this.tab_add_purchase.Location = new System.Drawing.Point(4, 22);
            this.tab_add_purchase.Name = "tab_add_purchase";
            this.tab_add_purchase.Padding = new System.Windows.Forms.Padding(3);
            this.tab_add_purchase.Size = new System.Drawing.Size(768, 400);
            this.tab_add_purchase.TabIndex = 1;
            this.tab_add_purchase.Text = "Добавить покупку";
            this.tab_add_purchase.UseVisualStyleBackColor = true;
            // 
            // tab_report
            // 
            this.tab_report.Controls.Add(this.dataGridView1);
            this.tab_report.Location = new System.Drawing.Point(4, 22);
            this.tab_report.Name = "tab_report";
            this.tab_report.Size = new System.Drawing.Size(768, 400);
            this.tab_report.TabIndex = 2;
            this.tab_report.Text = "Отчет";
            this.tab_report.UseVisualStyleBackColor = true;
            // 
            // btn_create_table
            // 
            this.btn_create_table.Location = new System.Drawing.Point(7, 7);
            this.btn_create_table.Name = "btn_create_table";
            this.btn_create_table.Size = new System.Drawing.Size(311, 167);
            this.btn_create_table.TabIndex = 0;
            this.btn_create_table.Text = "Создать таблицу";
            this.btn_create_table.UseVisualStyleBackColor = true;
            this.btn_create_table.Click += new System.EventHandler(this.btn_create_table_Click);
            // 
            // lbl_table_status
            // 
            this.lbl_table_status.Location = new System.Drawing.Point(325, 7);
            this.lbl_table_status.Name = "lbl_table_status";
            this.lbl_table_status.Size = new System.Drawing.Size(301, 167);
            this.lbl_table_status.TabIndex = 1;
            this.lbl_table_status.Text = "TABLESTATUS";
            this.lbl_table_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_purchase_date
            // 
            this.dtp_purchase_date.Location = new System.Drawing.Point(7, 7);
            this.dtp_purchase_date.Name = "dtp_purchase_date";
            this.dtp_purchase_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_purchase_date.TabIndex = 0;
            // 
            // lb_products
            // 
            this.lb_products.FormattingEnabled = true;
            this.lb_products.Location = new System.Drawing.Point(214, 7);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(120, 95);
            this.lb_products.TabIndex = 1;
            // 
            // tab_add_product
            // 
            this.tab_add_product.Controls.Add(this.btn_add_product);
            this.tab_add_product.Controls.Add(this.tb_add_product_name);
            this.tab_add_product.Location = new System.Drawing.Point(4, 22);
            this.tab_add_product.Name = "tab_add_product";
            this.tab_add_product.Size = new System.Drawing.Size(768, 400);
            this.tab_add_product.TabIndex = 3;
            this.tab_add_product.Text = "Добавить товар";
            this.tab_add_product.UseVisualStyleBackColor = true;
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(341, 7);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(100, 20);
            this.tb_cost.TabIndex = 2;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(448, 6);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(100, 20);
            this.tb_quantity.TabIndex = 3;
            // 
            // tb_add_product_name
            // 
            this.tb_add_product_name.Location = new System.Drawing.Point(4, 4);
            this.tb_add_product_name.Name = "tb_add_product_name";
            this.tb_add_product_name.Size = new System.Drawing.Size(100, 20);
            this.tb_add_product_name.TabIndex = 0;
            // 
            // btn_add_product
            // 
            this.btn_add_product.Location = new System.Drawing.Point(111, 4);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(75, 23);
            this.btn_add_product.TabIndex = 1;
            this.btn_add_product.Text = "button1";
            this.btn_add_product.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab_create_table.ResumeLayout(false);
            this.tab_add_purchase.ResumeLayout(false);
            this.tab_add_purchase.PerformLayout();
            this.tab_report.ResumeLayout(false);
            this.tab_add_product.ResumeLayout(false);
            this.tab_add_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_create_table;
        private System.Windows.Forms.TabPage tab_add_purchase;
        private System.Windows.Forms.TabPage tab_report;
        private System.Windows.Forms.Label lbl_table_status;
        private System.Windows.Forms.Button btn_create_table;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.ListBox lb_products;
        private System.Windows.Forms.DateTimePicker dtp_purchase_date;
        private System.Windows.Forms.TabPage tab_add_product;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.TextBox tb_add_product_name;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

