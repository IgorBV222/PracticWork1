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

namespace PracticWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SQLiteConnection conn;
        private DataTable dtGoods_type;
        private DataTable dtGoods;
        private DataTable dtSuppliers;
        private DataTable dtStock;

        private SQLiteDataAdapter adGoods_type;
        private SQLiteDataAdapter adGoods;
        private SQLiteDataAdapter adSuppliers;
        private SQLiteDataAdapter adStock;


        private void SelectDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                conn = new SQLiteConnection("DataSource=" + filename);
                conn.Open(); // создаст файл 
                string sqltext = "select name from sqlite_master where type='table';";

                using (SQLiteCommand cmd = new SQLiteCommand(sqltext, conn))
                {
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    CreateTablesToolStripMenuItem.Enabled = !reader.HasRows; // отключаем кнопку создания таблиц
                    if (reader.HasRows)
                    {                        
                        dGVShowGoods_type();
                        dGVShowGoods();
                        dGVShowSuppliers();
                        dGVShowStock();
                    }
                    reader.Close();
                    conn.Close();
                }                             
            }
            else
            {
                //указать что будет если база не откроится база данных
            }
        }

        private void CreateTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqltext = "create table Goods_type(id INTEGER PRIMARY KEY AUTOINCREMENT, [name] VARCHAR(20));" + 
                "create table Goods(id INTEGER PRIMARY KEY AUTOINCREMENT, id_goods_type INTEGER REFERENCES Goods_type(id), [name] VARCHAR(20));" + 
                "create table Suppliers(id INTEGER PRIMARY KEY AUTOINCREMENT, [name] VARCHAR(20));" +
                "create table Stock(id INTEGER PRIMARY KEY AUTOINCREMENT, id_good INTEGER REFERENCES Goods(id), " +
                "id_supplier INTEGER REFERENCES Suppliers(id), " +
                "amount INTEGER, cost_price REAL, [date] TEXT);";

            using (SQLiteCommand cmd = new SQLiteCommand(sqltext, conn))
            {                
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CreateTablesToolStripMenuItem.Enabled = false; // отключаем кнопку создания таблиц
        }

        private void dGVShowGoods_type()
        {
            string sqltext = "select * from Goods_type;";
            dtGoods_type = new DataTable();
            adGoods_type = new SQLiteDataAdapter(sqltext, conn);
            adGoods_type.Fill(dtGoods_type);
            dGVGoods_type.DataSource = dtGoods_type;
        }

        private void dGVShowGoods()
        {
            string sqltext = "select * from Goods;";
            dtGoods = new DataTable();
            adGoods = new SQLiteDataAdapter(sqltext, conn);
            adGoods.Fill(dtGoods);
            dGVGoods.DataSource = dtGoods;
        }

        private void dGVShowSuppliers() 
        {
            string sqltext = "select * from Suppliers;";
            dtSuppliers = new DataTable();
            adSuppliers = new SQLiteDataAdapter(sqltext, conn);
            adSuppliers.Fill(dtSuppliers);
            dGVSuppliers.DataSource = dtSuppliers;
        }

        private void dGVShowStock()
        {
            string sqltext = "select * from Stock;";
            dtStock = new DataTable();
            adStock = new SQLiteDataAdapter(sqltext, conn);
            adStock.Fill(dtStock);
            dGVStock.DataSource = dtStock;
        }

        private void allInformationAboutTheGoodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void goodWithMaximumQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void goodWithMinimalQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void goodWithMinimalCostToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void goodWithMaximumCostToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
