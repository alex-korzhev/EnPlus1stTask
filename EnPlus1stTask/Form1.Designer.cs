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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_fill_table = new System.Windows.Forms.Button();
            this.lbl_table_status = new System.Windows.Forms.Label();
            this.btn_create_table = new System.Windows.Forms.Button();
            this.tab_add_purchase = new System.Windows.Forms.TabPage();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.dtp_purchase_date = new System.Windows.Forms.DateTimePicker();
            this.tab_add_product = new System.Windows.Forms.TabPage();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.tb_add_product_name = new System.Windows.Forms.TextBox();
            this.tab_report = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_Products = new System.Windows.Forms.ComboBox();
            this.btn_make_purchase = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_create_table.SuspendLayout();
            this.tab_add_purchase.SuspendLayout();
            this.tab_add_product.SuspendLayout();
            this.tab_report.SuspendLayout();
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
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tab_create_table
            // 
            this.tab_create_table.Controls.Add(this.button1);
            this.tab_create_table.Controls.Add(this.btn_fill_table);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_fill_table
            // 
            this.btn_fill_table.Location = new System.Drawing.Point(7, 181);
            this.btn_fill_table.Name = "btn_fill_table";
            this.btn_fill_table.Size = new System.Drawing.Size(311, 111);
            this.btn_fill_table.TabIndex = 2;
            this.btn_fill_table.Text = "Заполнить таблицу";
            this.btn_fill_table.UseVisualStyleBackColor = true;
            this.btn_fill_table.Click += new System.EventHandler(this.btn_fill_table_Click);
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
            // tab_add_purchase
            // 
            this.tab_add_purchase.Controls.Add(this.btn_make_purchase);
            this.tab_add_purchase.Controls.Add(this.cb_Products);
            this.tab_add_purchase.Controls.Add(this.tb_quantity);
            this.tab_add_purchase.Controls.Add(this.tb_cost);
            this.tab_add_purchase.Controls.Add(this.dtp_purchase_date);
            this.tab_add_purchase.Location = new System.Drawing.Point(4, 22);
            this.tab_add_purchase.Name = "tab_add_purchase";
            this.tab_add_purchase.Padding = new System.Windows.Forms.Padding(3);
            this.tab_add_purchase.Size = new System.Drawing.Size(768, 400);
            this.tab_add_purchase.TabIndex = 1;
            this.tab_add_purchase.Text = "Добавить покупку";
            this.tab_add_purchase.UseVisualStyleBackColor = true;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(389, 8);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(100, 20);
            this.tb_quantity.TabIndex = 3;
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(283, 8);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(100, 20);
            this.tb_cost.TabIndex = 2;
            // 
            // dtp_purchase_date
            // 
            this.dtp_purchase_date.Location = new System.Drawing.Point(7, 7);
            this.dtp_purchase_date.Name = "dtp_purchase_date";
            this.dtp_purchase_date.Size = new System.Drawing.Size(143, 20);
            this.dtp_purchase_date.TabIndex = 0;
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
            // btn_add_product
            // 
            this.btn_add_product.Location = new System.Drawing.Point(111, 4);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(75, 23);
            this.btn_add_product.TabIndex = 1;
            this.btn_add_product.Text = "Добавить товар";
            this.btn_add_product.UseVisualStyleBackColor = true;
            // 
            // tb_add_product_name
            // 
            this.tb_add_product_name.Location = new System.Drawing.Point(4, 4);
            this.tb_add_product_name.Name = "tb_add_product_name";
            this.tb_add_product_name.Size = new System.Drawing.Size(100, 20);
            this.tb_add_product_name.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // cb_Products
            // 
            this.cb_Products.FormattingEnabled = true;
            this.cb_Products.Location = new System.Drawing.Point(156, 7);
            this.cb_Products.Name = "cb_Products";
            this.cb_Products.Size = new System.Drawing.Size(121, 21);
            this.cb_Products.TabIndex = 4;
            this.cb_Products.SelectionChangeCommitted += new System.EventHandler(this.cb_Products_SelectionChangeCommitted);
            // 
            // btn_make_purchase
            // 
            this.btn_make_purchase.Location = new System.Drawing.Point(495, 8);
            this.btn_make_purchase.Name = "btn_make_purchase";
            this.btn_make_purchase.Size = new System.Drawing.Size(75, 23);
            this.btn_make_purchase.TabIndex = 5;
            this.btn_make_purchase.Text = "Купить";
            this.btn_make_purchase.UseVisualStyleBackColor = true;
            this.btn_make_purchase.Click += new System.EventHandler(this.btn_make_purchase_Click);
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
            this.tab_add_product.ResumeLayout(false);
            this.tab_add_product.PerformLayout();
            this.tab_report.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dtp_purchase_date;
        private System.Windows.Forms.TabPage tab_add_product;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.TextBox tb_add_product_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_fill_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_Products;
        private System.Windows.Forms.Button btn_make_purchase;
    }
}

