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
    public partial class F_Cities : Form
    {
        public F_Cities()
        {
            InitializeComponent();
        }

        private void Cities_Load(object sender, EventArgs e)
        {
            this.citiesTableAdapter.Fill(this.database1DataSet4.cities);
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
            Query = "SELECT * FROM Cities";
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
            ID = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sqlconn = new SqlConnection(cs);
                sqlconn.Open();
                Query = "INSERT INTO Cities (city) VALUES (@city)";
                sqlcomm = new SqlCommand(Query, sqlconn);
                sqlcomm.Parameters.AddWithValue("@city", textBox1.Text);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
                MessageBox.Show("Inserted");
                DisplayData();
                ClearData();
            }
            else MessageBox.Show("Insert failed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sqlconn = new SqlConnection(cs);
                sqlconn.Open();
                Query = "UPDATE Cities SET city=@city WHERE ID=@ID";
                sqlcomm = new SqlCommand(Query, sqlconn);
                sqlcomm.Parameters.AddWithValue("@ID", ID);
                sqlcomm.Parameters.AddWithValue("@city", textBox1.Text);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
                MessageBox.Show("Updated");
                DisplayData();
                ClearData();
            }
            else MessageBox.Show("Update failed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                sqlconn = new SqlConnection(cs);
                sqlconn.Open();
                Query = "DELETE Cities WHERE ID = @ID";
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
