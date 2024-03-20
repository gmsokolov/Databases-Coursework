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
    public partial class F_Clients : Form
    {
        public F_Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.database1DataSet3.clients);
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
            Query = "SELECT * FROM Clients";
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
            textBox3.Text = "";
            ID = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                sqlconn = new SqlConnection(cs);
                sqlconn.Open();
                Query = "INSERT INTO Clients (first_name,last_name,phone) VALUES (@first_name,@last_name,@phone)";
                sqlcomm = new SqlCommand(Query, sqlconn);
                sqlcomm.Parameters.AddWithValue("@first_name", textBox1.Text);
                sqlcomm.Parameters.AddWithValue("@last_name", textBox2.Text);
                sqlcomm.Parameters.AddWithValue("@phone", textBox3.Text);
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
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                sqlconn = new SqlConnection(cs);
                sqlconn.Open();
                Query = "UPDATE Clients SET first_name=@first_name,last_name=@last_name,phone=@phone WHERE ID=@ID";
                sqlcomm = new SqlCommand(Query, sqlconn);
                sqlcomm.Parameters.AddWithValue("@ID", ID);
                sqlcomm.Parameters.AddWithValue("@first_name", textBox1.Text);
                sqlcomm.Parameters.AddWithValue("@last_name", textBox2.Text);
                sqlcomm.Parameters.AddWithValue("@phone",textBox3.Text);
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
                Query = "DELETE Clients WHERE ID = @ID";
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
