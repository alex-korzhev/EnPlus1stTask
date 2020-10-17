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
            this.tab_report = new System.Windows.Forms.TabPage();
            this.btn_generate_report = new System.Windows.Forms.Button();
            this.dtp_date_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_date_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_date_to = new System.Windows.Forms.Label();
            this.lbl_date_from = new System.Windows.Forms.Label();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.tab_add_purchase = new System.Windows.Forms.TabPage();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_products = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_make_purchase = new System.Windows.Forms.Button();
            this.cb_Products = new System.Windows.Forms.ComboBox();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.dtp_purchase_date = new System.Windows.Forms.DateTimePicker();
            this.tab_create_table = new System.Windows.Forms.TabPage();
            this.btn_fill_table = new System.Windows.Forms.Button();
            this.lbl_table_status = new System.Windows.Forms.Label();
            this.btn_create_table = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.tab_add_purchase.SuspendLayout();
            this.tab_create_table.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_report
            // 
            this.tab_report.Controls.Add(this.btn_generate_report);
            this.tab_report.Controls.Add(this.dtp_date_to);
            this.tab_report.Controls.Add(this.dtp_date_from);
            this.tab_report.Controls.Add(this.lbl_date_to);
            this.tab_report.Controls.Add(this.lbl_date_from);
            this.tab_report.Controls.Add(this.dgv_report);
            this.tab_report.Location = new System.Drawing.Point(4, 22);
            this.tab_report.Name = "tab_report";
            this.tab_report.Size = new System.Drawing.Size(514, 272);
            this.tab_report.TabIndex = 2;
            this.tab_report.Text = "Отчет";
            this.tab_report.UseVisualStyleBackColor = true;
            // 
            // btn_generate_report
            // 
            this.btn_generate_report.Location = new System.Drawing.Point(302, 6);
            this.btn_generate_report.Name = "btn_generate_report";
            this.btn_generate_report.Size = new System.Drawing.Size(209, 47);
            this.btn_generate_report.TabIndex = 12;
            this.btn_generate_report.Text = "Сформировать отчёт";
            this.btn_generate_report.UseVisualStyleBackColor = true;
            this.btn_generate_report.Click += new System.EventHandler(this.btn_generate_report_Click);
            // 
            // dtp_date_to
            // 
            this.dtp_date_to.Location = new System.Drawing.Point(125, 33);
            this.dtp_date_to.Name = "dtp_date_to";
            this.dtp_date_to.Size = new System.Drawing.Size(170, 20);
            this.dtp_date_to.TabIndex = 11;
            // 
            // dtp_date_from
            // 
            this.dtp_date_from.Location = new System.Drawing.Point(125, 6);
            this.dtp_date_from.Name = "dtp_date_from";
            this.dtp_date_from.Size = new System.Drawing.Size(170, 20);
            this.dtp_date_from.TabIndex = 10;
            // 
            // lbl_date_to
            // 
            this.lbl_date_to.BackColor = System.Drawing.Color.LightGray;
            this.lbl_date_to.Location = new System.Drawing.Point(19, 32);
            this.lbl_date_to.Name = "lbl_date_to";
            this.lbl_date_to.Size = new System.Drawing.Size(100, 21);
            this.lbl_date_to.TabIndex = 9;
            this.lbl_date_to.Text = "Дата по:";
            this.lbl_date_to.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_date_from
            // 
            this.lbl_date_from.BackColor = System.Drawing.Color.LightGray;
            this.lbl_date_from.Location = new System.Drawing.Point(19, 5);
            this.lbl_date_from.Name = "lbl_date_from";
            this.lbl_date_from.Size = new System.Drawing.Size(100, 21);
            this.lbl_date_from.TabIndex = 8;
            this.lbl_date_from.Text = "Дата с:";
            this.lbl_date_from.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_report
            // 
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.Location = new System.Drawing.Point(4, 57);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.Size = new System.Drawing.Size(510, 215);
            this.dgv_report.TabIndex = 0;
            // 
            // tab_add_purchase
            // 
            this.tab_add_purchase.Controls.Add(this.lbl_quantity);
            this.tab_add_purchase.Controls.Add(this.lbl_cost);
            this.tab_add_purchase.Controls.Add(this.lbl_products);
            this.tab_add_purchase.Controls.Add(this.lbl_date);
            this.tab_add_purchase.Controls.Add(this.btn_make_purchase);
            this.tab_add_purchase.Controls.Add(this.cb_Products);
            this.tab_add_purchase.Controls.Add(this.tb_quantity);
            this.tab_add_purchase.Controls.Add(this.tb_cost);
            this.tab_add_purchase.Controls.Add(this.dtp_purchase_date);
            this.tab_add_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_add_purchase.Location = new System.Drawing.Point(4, 22);
            this.tab_add_purchase.Name = "tab_add_purchase";
            this.tab_add_purchase.Padding = new System.Windows.Forms.Padding(3);
            this.tab_add_purchase.Size = new System.Drawing.Size(514, 272);
            this.tab_add_purchase.TabIndex = 1;
            this.tab_add_purchase.Text = "Добавить покупку";
            this.tab_add_purchase.UseVisualStyleBackColor = true;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.BackColor = System.Drawing.Color.LightGray;
            this.lbl_quantity.Location = new System.Drawing.Point(23, 115);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(100, 21);
            this.lbl_quantity.TabIndex = 9;
            this.lbl_quantity.Text = "Количество";
            this.lbl_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cost
            // 
            this.lbl_cost.BackColor = System.Drawing.Color.LightGray;
            this.lbl_cost.Location = new System.Drawing.Point(23, 88);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(100, 21);
            this.lbl_cost.TabIndex = 8;
            this.lbl_cost.Text = "Цена";
            this.lbl_cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_products
            // 
            this.lbl_products.BackColor = System.Drawing.Color.LightGray;
            this.lbl_products.Location = new System.Drawing.Point(23, 59);
            this.lbl_products.Name = "lbl_products";
            this.lbl_products.Size = new System.Drawing.Size(100, 21);
            this.lbl_products.TabIndex = 7;
            this.lbl_products.Text = "Товар";
            this.lbl_products.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_date
            // 
            this.lbl_date.BackColor = System.Drawing.Color.LightGray;
            this.lbl_date.Location = new System.Drawing.Point(23, 32);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "Дата покупки";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_make_purchase
            // 
            this.btn_make_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_make_purchase.Location = new System.Drawing.Point(129, 142);
            this.btn_make_purchase.Name = "btn_make_purchase";
            this.btn_make_purchase.Size = new System.Drawing.Size(170, 32);
            this.btn_make_purchase.TabIndex = 5;
            this.btn_make_purchase.Text = "Купить";
            this.btn_make_purchase.UseVisualStyleBackColor = true;
            this.btn_make_purchase.Click += new System.EventHandler(this.btn_make_purchase_Click);
            // 
            // cb_Products
            // 
            this.cb_Products.FormattingEnabled = true;
            this.cb_Products.Location = new System.Drawing.Point(129, 59);
            this.cb_Products.Name = "cb_Products";
            this.cb_Products.Size = new System.Drawing.Size(170, 23);
            this.cb_Products.TabIndex = 4;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_quantity.Location = new System.Drawing.Point(129, 115);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(170, 21);
            this.tb_quantity.TabIndex = 3;
            // 
            // tb_cost
            // 
            this.tb_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_cost.Location = new System.Drawing.Point(129, 88);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(170, 21);
            this.tb_cost.TabIndex = 2;
            // 
            // dtp_purchase_date
            // 
            this.dtp_purchase_date.Location = new System.Drawing.Point(129, 32);
            this.dtp_purchase_date.Name = "dtp_purchase_date";
            this.dtp_purchase_date.Size = new System.Drawing.Size(170, 21);
            this.dtp_purchase_date.TabIndex = 0;
            // 
            // tab_create_table
            // 
            this.tab_create_table.Controls.Add(this.btn_fill_table);
            this.tab_create_table.Controls.Add(this.lbl_table_status);
            this.tab_create_table.Controls.Add(this.btn_create_table);
            this.tab_create_table.Location = new System.Drawing.Point(4, 22);
            this.tab_create_table.Name = "tab_create_table";
            this.tab_create_table.Padding = new System.Windows.Forms.Padding(3);
            this.tab_create_table.Size = new System.Drawing.Size(514, 272);
            this.tab_create_table.TabIndex = 0;
            this.tab_create_table.Text = "Создать таблицу";
            this.tab_create_table.UseVisualStyleBackColor = true;
            // 
            // btn_fill_table
            // 
            this.btn_fill_table.Location = new System.Drawing.Point(7, 70);
            this.btn_fill_table.Name = "btn_fill_table";
            this.btn_fill_table.Size = new System.Drawing.Size(158, 63);
            this.btn_fill_table.TabIndex = 2;
            this.btn_fill_table.Text = "Заполнить таблицу";
            this.btn_fill_table.UseVisualStyleBackColor = true;
            this.btn_fill_table.Click += new System.EventHandler(this.btn_fill_table_Click);
            // 
            // lbl_table_status
            // 
            this.lbl_table_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_table_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_table_status.Location = new System.Drawing.Point(170, 7);
            this.lbl_table_status.Name = "lbl_table_status";
            this.lbl_table_status.Size = new System.Drawing.Size(250, 57);
            this.lbl_table_status.TabIndex = 1;
            this.lbl_table_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_create_table
            // 
            this.btn_create_table.Location = new System.Drawing.Point(7, 7);
            this.btn_create_table.Name = "btn_create_table";
            this.btn_create_table.Size = new System.Drawing.Size(157, 57);
            this.btn_create_table.TabIndex = 0;
            this.btn_create_table.Text = "Создать таблицу";
            this.btn_create_table.UseVisualStyleBackColor = true;
            this.btn_create_table.Click += new System.EventHandler(this.btn_create_table_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_create_table);
            this.tabControl1.Controls.Add(this.tab_add_purchase);
            this.tabControl1.Controls.Add(this.tab_report);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(522, 298);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 314);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Покупки";
            this.tab_report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.tab_add_purchase.ResumeLayout(false);
            this.tab_add_purchase.PerformLayout();
            this.tab_create_table.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_report;
        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.TabPage tab_add_purchase;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_make_purchase;
        private System.Windows.Forms.ComboBox cb_Products;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.DateTimePicker dtp_purchase_date;
        private System.Windows.Forms.TabPage tab_create_table;
        private System.Windows.Forms.Button btn_fill_table;
        private System.Windows.Forms.Label lbl_table_status;
        private System.Windows.Forms.Button btn_create_table;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_generate_report;
        private System.Windows.Forms.DateTimePicker dtp_date_to;
        private System.Windows.Forms.DateTimePicker dtp_date_from;
        private System.Windows.Forms.Label lbl_date_to;
        private System.Windows.Forms.Label lbl_date_from;
    }
}

