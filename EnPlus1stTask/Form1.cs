using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace EnPlus1stTask
{

    public partial class Form1 : Form
    {

        DBHandler dbHandler;
        public Form1()
        {
            InitializeComponent();
            dbHandler = new DBHandler();
            showCheckDB();
        }

        private void btn_create_table_Click(object sender, EventArgs e)
        {
            dbHandler.InitDatabase();
            showCheckDB();
        }

        private void btn_fill_table_Click(object sender, EventArgs e)
        {
            dbHandler.FillDB();
        }

        private void RepopulateCBProducts()
        {
            cb_Products.Items.Clear();
            List<Product> lp = dbHandler.GetProducts();
            foreach (Product p in lp)
            {
                cb_Products.Items.Add(p);
            }
        }

        private void showCheckDB()
        {
            if (dbHandler.CheckDB())
            {
                lbl_table_status.Text = "ТАБЛИЦА СОЗДАНА";
                lbl_table_status.ForeColor = Color.Green;
            }
            else
            {
                lbl_table_status.Text = "ТАБЛИЦА НЕ СОЗДАНА";
                lbl_table_status.ForeColor = Color.Red;
            }
        }

        private void showReport()
        {
            DataSet dataSet = dbHandler.GetReport(
                dtp_date_from.Value.ToString("yyyy-MM-dd"),
                dtp_date_to.Value.ToString("yyyy-MM-dd"));
            if (dataSet.Tables[0].Rows.Count > 1) { 
                dgv_report.DataSource = dataSet.Tables[0].DefaultView;
                dgv_report.Columns["OrderNr"].Visible = false;
                dgv_report.Columns["GTNR"].Visible = false;
                dgv_report.ReadOnly = true;
                foreach (DataGridViewColumn column in dgv_report.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                dgv_report.AllowUserToAddRows = false;
                dgv_report.RowHeadersVisible = false;
            } else
            {
                MessageBox.Show("Таблица пуста");
            }

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_create_table"])
            {
                showCheckDB();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_add_purchase"])
            {
                RepopulateCBProducts();
            }

        }

        private void btn_make_purchase_Click(object sender, EventArgs e)
        {
            if(dbHandler.MakePurchase(cb_Products.Text,
                dtp_purchase_date.Value.ToString("yyyy-MM-dd"),
                Double.Parse(tb_cost.Text),
                Int32.Parse(tb_quantity.Text)))
            {
                MessageBox.Show("Покупка совершена");
                RepopulateCBProducts();
                cb_Products.Text = "";
                dtp_purchase_date.Value = DateTime.Today;
                tb_cost.Text = "";
                tb_quantity.Text = "";
            } else
            {
                MessageBox.Show("ОШИБКА!");
            }
        }

        private void btn_generate_report_Click(object sender, EventArgs e)
        {
            showReport();
        }

    }

    public class Product
    {
        public string Value { get; set; }
        public int Tag { get; set; }
        
        public Product(string value, int tag)
        {
            Value = value;
            Tag = tag;
        }

        public override string ToString()
        {
            return Value;
        }
    }

    public class DBHandler
    {
        private readonly string dbFile = "PurchasesProducts.sqlite";
        private readonly string dbConnectionString = "Data Source=PurchasesProducts.sqlite;Version=3";
        private List<Product> existingProducts;

        public DBHandler() {
            existingProducts = new List<Product>();
        }

        public DataSet GetReport(string dateFrom, string dateTo)
        {

            string sql = @"SELECT products.name as 'Товар', '1' as OrderNr, '1' AS GTNR, " +
                "purchases.date as 'Дата покупки', purchases.cost as 'Цена', purchases.quantity as 'Количество' " +
                "FROM purchases INNER JOIN products ON purchases.product_id = products.id " +
                @"WHERE purchases.date BETWEEN '" + dateFrom + "' AND '" + dateTo + "' " + 
                "union all select 'Общий итог', '2' AS OrderNr, '2' AS GTNR, ' ', SUM(purchases.cost)," +
                "SUM(purchases.quantity) " +
                "FROM purchases INNER JOIN products ON purchases.product_id = products.id " +
                @"WHERE purchases.date BETWEEN '" + dateFrom + "' AND '" + dateTo + "' " +
                "union all select products.name ||' итого', '3' AS OrderNr, '1' AS GTNR,' ', SUM(purchases.cost), SUM(purchases.quantity) " +
                "FROM purchases INNER JOIN products ON purchases.product_id = products.id " +
                @"WHERE purchases.date BETWEEN '" + dateFrom + "' AND '" + dateTo + "' " +
                " group by products.name order by GTNR, products.name, OrderNr;";
          
            using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        DataSet dataSet = new DataSet();
                        var dataAdapter = new SQLiteDataAdapter(sql, connection);  
                        dataAdapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
            
        }

        private int InsertProduct(string productName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                string sql = $"INSERT INTO products (name) VALUES ('{productName}');";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
                sql = $"SELECT id FROM products WHERE name='{productName}';";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        Product p = new Product(productName, Int32.Parse(reader["id"].ToString()));
                        existingProducts.Add(p);
                        return p.Tag;
                    }
                }
            }

        }

        public bool MakePurchase(string productName, string date, double cost, int quantity) 
        {
            int product_id;
            if (!CheckProductExists(productName))
            {
                product_id = InsertProduct(productName);
            } else
            {
                product_id = existingProducts.Find(ep => ep.Value == productName).Tag;
            }
            string sql = $"INSERT INTO purchases (product_id, date, cost, quantity) " +
                $"VALUES ({product_id}, '{date}', {cost}, {quantity});";
            using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    return (command.ExecuteNonQuery() == 1) ? true : false;
                }
            }

        }

        private bool CheckProductExists(String productName)
        {
            return existingProducts.Exists(ep => ep.Value == productName);
        }

        public List<Product> GetProducts()
        {
            existingProducts.Clear();
            string sql = "SELECT id, name FROM products;";
            using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            existingProducts.Add(new Product(reader["name"].ToString(), 
                                Int32.Parse(reader["id"].ToString())));
                        }
                    }
                }
            }
            return existingProducts;
        }

        public void FillDB()
        {
            if (CheckDB())
            {
                string sql = "INSERT INTO products (name) VALUES ('Яблоко'), ('Груша'), ('Апельсин'), ('Арбуз');";
                using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                sql = "INSERT INTO purchases (product_id, date, cost, quantity) VALUES (1, '2020-10-17', 10, 5), " +
                    "(2, '2020-10-18', 15, 7), (3, '2020-10-18', 3, 10), (4, '2020-10-18', 6, 3), (1, '2020-10-18', 10, 7);";
                using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }


            }
        }

        public Boolean CheckDB()
        {
            //Check if database file itself exists
            if (!File.Exists(dbFile)) { return false; }
            string sql = "SELECT count(*) AS tblExists FROM sqlite_master WHERE type='table' AND name='products';";
            using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        if (Int32.Parse(reader["tblExists"].ToString()) == 0) { return false; }
                    }
                }

                sql = "SELECT count(*) AS tblExists FROM sqlite_master WHERE type='table' AND name='purchases';";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        if (Int32.Parse(reader["tblExists"].ToString()) == 0) { return false; }
                    }
                }
            }
            return true;
        }

        public void InitDatabase()
        {
            if (File.Exists(dbFile)) { File.Delete(dbFile); }
            SQLiteConnection.CreateFile(dbFile);
            using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();

                string sql = "CREATE TABLE products (id INTEGER PRIMARY KEY, name varchar(100) NOT NULL);";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }

                sql = "CREATE TABLE purchases (id INTEGER PRIMARY KEY, product_id INTEGER NOT NULL," +
                " date TEXT NOT NULL, cost REAL NOT NULL, quantity INTEGER NOT NULL," +
                " FOREIGN KEY (product_id) REFERENCES products(id));";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
