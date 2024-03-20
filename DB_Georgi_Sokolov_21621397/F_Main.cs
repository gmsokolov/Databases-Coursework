using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace DB_Georgi_Sokolov_21621397
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Categories categories = new F_Categories();
            categories.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Items items = new F_Items();
            items.Show();
        }

        private void cartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Carts carts = new F_Carts();
            carts.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Clients clients = new F_Clients();
            clients.Show();
        }

        private void citiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Cities cities = new F_Cities();
            cities.Show();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Stores stores = new F_Stores();
            stores.Show();
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Purchases purchases = new F_Purchases();
            purchases.Show();
        }

        private void setTextboxes(bool enabled)
        {
            textBox1.Enabled = !enabled;
            textBox2.Enabled = enabled;
            textBox3.Enabled = enabled;
        }

        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gmsokolov\source\repos\DB_Georgi_Sokolov_21621397\DB_Store_Chain.mdf;Integrated Security=True";
        SqlConnection sqlconn;
        SqlCommand sqlcomm;
        string Query;
        DataTable dt;
        SqlDataAdapter sqladapter;
        int ID = 0;

        private void DisplayData(string query)
        {
            sqlconn = new SqlConnection(cs);
            sqlcomm = new SqlCommand(query, sqlconn);
            sqladapter = new SqlDataAdapter();
            dt = new DataTable();
            sqladapter.SelectCommand = sqlcomm;
            sqladapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            ID = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            switch (groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name)
            {
                case "radioButton1":
                    Query = "SELECT c.first_name, c.last_name, p.purchase_date, i.item, cat.category, i.price, ca.quantity" +
                        " FROM clients c" +
                        " JOIN purchases p ON c.id = p.clients_id" +
                        " JOIN carts ca ON p.id = ca.purchases_id" +
                        " JOIN items i ON ca.items_id = i.id" +
                        " JOIN categories cat ON i.categories_id = cat.id" +
                        " WHERE c.id = " + textBox1.Text +
                        " ORDER BY p.purchase_date ASC, i.item ASC;";
                    DisplayData(Query);
                    break;
                case "radioButton2":

                    Query = "SELECT p.id AS purchase_id, p.purchase_date, cl.id AS client_id, cl.first_name AS client_first_name, cl.last_name AS client_last_name, SUM(i.price * ct.quantity) AS total_price" +
                        " FROM purchases p" +
                        " JOIN clients cl ON p.clients_id = cl.id" +
                        " JOIN carts ct ON p.id = ct.purchases_id" +
                        " JOIN items i ON ct.items_id = i.id" +
                        " WHERE p.stores_id = " + textBox1.Text +
                        " GROUP BY p.purchase_date, p.id, cl.id, cl.first_name, cl.last_name" +
                        " ORDER BY p.purchase_date;";
                    DisplayData(Query);
                    break;
                case "radioButton3":
                    Query = "SELECT p.id AS purchase_id, p.purchase_date, s.street AS store_street, cl.id AS client_id, cl.first_name AS client_first_name, cl.last_name AS client_last_name, SUM(i.price * ct.quantity) AS total_price" +
                        " FROM purchases p" +
                        " JOIN clients cl ON p.clients_id = cl.id" +
                        " JOIN carts ct ON p.id = ct.purchases_id" +
                        " JOIN items i ON ct.items_id = i.id" +
                        " JOIN stores s ON p.stores_id = s.id" +
                        " JOIN cities c ON s.cities_id = c.id" +
                        " WHERE c.city = \'" + textBox1.Text + "\'" +
                        " GROUP BY p.id, p.purchase_date, s.street, cl.id, cl.first_name, cl.last_name" +
                        " ORDER BY p.purchase_date;";
                    DisplayData(Query);
                    break;
                case "radioButton4":
                    Query = "SELECT p.id AS purchase_id, p.purchase_date, cl.id AS client_id, cl.first_name AS client_first_name, cl.last_name AS client_last_name, SUM(i.price * ct.quantity) AS total_price, s.street AS store_street, c.city" +
                        " FROM purchases p" +
                        " JOIN clients cl ON p.clients_id = cl.id" +
                        " JOIN carts ct ON p.id = ct.purchases_id" +
                        " JOIN items i ON ct.items_id = i.id" +
                        " JOIN stores s ON p.stores_id = s.id" +
                        " JOIN cities c ON s.cities_id = c.id" +
                        " WHERE p.purchase_date BETWEEN \'" + textBox2.Text + "\' AND \'" + textBox3.Text + "\'" +
                        " GROUP BY p.id, p.purchase_date, cl.id, cl.first_name, cl.last_name, s.street, c.city" +
                        " ORDER BY p.purchase_date;";
                    DisplayData(Query);
                    break;
                case "radioButton5":
                    Query = "SELECT i.id AS item_id, i.item AS item_name, i.price AS item_price, COUNT(ct.items_id) AS number_of_purchases" +
                        " FROM items i" +
                        " JOIN carts ct ON i.id = ct.items_id" +
                        " JOIN categories c ON i.categories_id = c.id" +
                        " WHERE c.category = \'" + textBox1.Text + "\'" +
                        " GROUP BY i.id, i.item, i.price" +
                        " ORDER BY number_of_purchases DESC;";
                    DisplayData(Query);
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setTextboxes(false);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            setTextboxes(false);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            setTextboxes(false);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            setTextboxes(true);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            setTextboxes(false);

        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            setTextboxes(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            for(int i = 0; i <dataGridView1.RowCount; i++)
            {
                for(int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    xlWorkSheet.Cells[i+1, j+1] = dataGridView1.Rows[i].Cells[j].Value ?? "";
                }
            }
            xlWorkBook.SaveAs("C:\\Users\\gmsokolov\\Desktop\\ExcelReport.xls", Excel.XlFileFormat.xlWorkbookNormal,
                misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive,
                misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            MessageBox.Show("Excel file created , you can find the file C:\\Users\\gmsokolov\\Desktop\\ExcelReport.xls");
        }
    }
}
