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

namespace DB_Georgi_Sokolov_21621397
{
    public partial class F_Stores : Form
    {
        public F_Stores()
        {
            InitializeComponent();
        }

        private void F_Stores_Load(object sender, EventArgs e)
        {
            this.storesTableAdapter.Fill(this.dB_Store_ChainDataSet.stores);
        }

        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gmsokolov\source\repos\DB_Georgi_Sokolov_21621397\DB_Store_Chain.mdf;Integrated Security=True";
        SqlConnection sqlconn;
        SqlCommand sqlcomm;
        string Query;
        DataTable dt;
        SqlDataAdapter sqladapter;
        int ID = 0;

        private void DisplayData()
        {
            sqlconn = new SqlConnection(cs);
            Query = "SELECT * FROM Stores";
            sqlcomm = new SqlCommand(Query, sqlconn);
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
            ID = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" || textBox2.Text != "")
                {
                    sqlconn = new SqlConnection(cs);
                    sqlconn.Open();
                    Query = "INSERT INTO Stores (street,cities_id) VALUES (@street,@cities_id)";
                    sqlcomm = new SqlCommand(Query, sqlconn);
                    sqlcomm.Parameters.AddWithValue("@street", textBox1.Text);
                    sqlcomm.Parameters.AddWithValue("@cities_id", int.Parse(textBox2.Text));
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                    MessageBox.Show("Inserted");
                    DisplayData();
                    ClearData();
                }
                else throw new Exception();
            }
            catch
            {
                MessageBox.Show("Insert failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                try
                {
                    if (textBox1.Text != "" || textBox2.Text != "")
                    {
                        sqlconn = new SqlConnection(cs);
                        sqlconn.Open();
                        Query = "UPDATE Stores SET street=@street, cities_id=@cities_id WHERE ID=@ID";
                        sqlcomm = new SqlCommand(Query, sqlconn);
                        sqlcomm.Parameters.AddWithValue("@ID", ID);
                        sqlcomm.Parameters.AddWithValue("@street", textBox1.Text);
                        sqlcomm.Parameters.AddWithValue("@cities_id", int.Parse(textBox2.Text));
                        sqlcomm.ExecuteNonQuery();
                        sqlconn.Close();
                        MessageBox.Show("Updated");
                        DisplayData();
                        ClearData();
                    }
                    else throw new Exception();
                }
                catch
                {
                    MessageBox.Show("Update failed");
                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                sqlconn = new SqlConnection(cs);
                sqlconn.Open();
                Query = "DELETE Stores WHERE ID = @ID";
                sqlcomm = new SqlCommand(Query, sqlconn);
                sqlcomm.Parameters.AddWithValue("@ID", ID);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
                MessageBox.Show("Delted");
                DisplayData();
                ClearData();
            }
            else MessageBox.Show("Delete failed");
        }
    }
}
