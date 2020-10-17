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

    public class DBHandler
    {
        private readonly string dbFile = "PurchasesProducts.sqlite";
        private readonly string dbConnectionString = "Data Source=PurchasesProducts.sqlite;Version=3";

        public DBHandler() { }

        /*
         * SELECT columns
            FROM table1 
            INNER JOIN table2
            ON table1.column = table2.column;
         * 
         * 
         */

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
