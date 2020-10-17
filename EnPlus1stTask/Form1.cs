using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void btn_create_table_Click(object sender, EventArgs e)
        {
            dbHandler.InitDatabase();
        }

        private void btn_fill_table_Click(object sender, EventArgs e)
        {
            dbHandler.FillDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbHandler.ReadDB();
            dbHandler.ReadDB2();
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

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_create_table"])
            {
                if (dbHandler.CheckDB())
                {
                    lbl_table_status.Text = "ТАБЛИЦА СОЗДАНА";
                    lbl_table_status.ForeColor = Color.Green;
                } else
                {
                    lbl_table_status.Text = "ТАБЛИЦА НЕ СОЗДАНА";
                    lbl_table_status.ForeColor = Color.Red;
                }
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_add_product"])
            {

            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tab_add_purchase"])
            {
                RepopulateCBProducts();
            }

        }

        private void cb_Products_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show(cb_Products.SelectedItem.ToString());
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




        /* VOID
        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile("TEST1.sqlite");
            SQLiteConnection connection;
            connection = new SQLiteConnection("Data Source=TEST1.sqlite;Version=3;");
            connection.Open();
            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            sql = "insert into highscores (name, score) values ('Me', 3000)";
            command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            sql = "insert into highscores (name, score) values ('Myself', 6000)";
            command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            sql = "insert into highscores (name, score) values ('And I', 9001)";
            command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=TEST1.sqlite;Version=3;");
            connection.Open();
            string sql = "select * from highscores order by score desc";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
        }
        */
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

        public void lp()
        {
            foreach (Product p in existingProducts)
            {
                Console.WriteLine(p.Tag + " " + p.Value);
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

        public void ReadDB2()
        {
            
            string sql1 = "SELECT products.name, purchases.date, purchases.cost, purchases.quantity " +
                "FROM purchases INNER JOIN products ON purchases.product_id = products.id " +
            " union select products.name || '_Total' products.name, SUM(purchases.cost)sum," +
            "SUM(purchases.quantity)sum1 " +
            "FROM purchases INNER JOIN products ON purchases.product_id = products.id " +
            " group by products.name order by products.name;";

            string sql = "SELECT products.name, '1' as OrderNr, '1' AS GTNR, purchases.date, purchases.cost, purchases.quantity " +
                "FROM purchases INNER JOIN products ON purchases.product_id = products.id " +
            " union all select 'Grand_total', '2' AS OrderNr, '2' AS GTNR, ' ', SUM(purchases.cost)," +
            "SUM(purchases.quantity) " +
            "FROM purchases INNER JOIN products ON purchases.product_id = products.id " +
            "union all select products.name ||'_total', '3' AS OrderNr, '1' AS GTNR,' ', SUM(purchases.cost), SUM(purchases.quantity) " +
            "FROM purchases INNER JOIN products ON purchases.product_id = products.id " +
            " group by products.name order by GTNR, products.name, OrderNr;";


            string sqla = "SELECT products.name, '1' as OrderNr, purchases.date, purchases.cost, purchases.quantity " +
                "FROM purchases INNER JOIN products ON purchases.product_id = products.id " +
            " union all select products.name ||'_total', '2' AS OrderNr, ' ', SUM(purchases.cost)," +
            "SUM(purchases.quantity) " +
            "FROM purchases INNER JOIN products ON purchases.product_id = products.id " +
            " group by products.name order by products.name, OrderNr;";

            using (SQLiteConnection connection = new SQLiteConnection(dbConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("Name: " + reader["name"] + " - orderNr: " + reader["OrderNr"] + 
                                " - date: " + reader["date"] +
                    " - cost: " + reader["cost"] + " - quant: " + reader["quantity"]);
                        }
                    }
                }
            }
        }

        public void ReadDB()
        {
            SQLiteConnection connection = new SQLiteConnection(dbConnectionString);
            string sql = "SELECT products.name, purchases.date, purchases.cost, purchases.quantity " +
                "FROM purchases INNER JOIN products ON purchases.product_id = products.id;";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"] + " - date: " + reader["date"] + 
                    " - cost: " + reader["cost"] + " - quant: " + reader["quantity"]);                
            connection.Close();
            Console.WriteLine("--------------------------------");
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

        //SELECT count(*) FROM sqlite_master WHERE type='table' AND name='table_name';
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
