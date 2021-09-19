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

namespace Student_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagment;Integrated Security=True");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO tbl_insertion (Id,Name,Fname,Age,Gender,Address) VALUES ('" + txtID.Text + "','" + txtName.Text + "','" + txtFname.Text + "','" + txtAge.Text + "','" + cbbGender.Text + "','" + txtAddress.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted successfuly !!");
            txtID.Clear();
            txtName.Clear();
            txtFname.Clear();
            txtAge.Clear();
            txtAddress.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM tbl_insertion WHERE Id='" + txtID.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" DELETED Successfully...!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE tbl_insertion SET Name='" + txtName.Text + "',Fname ='" + txtFname.Text + "' ,Age='" + txtAge.Text + "',Gender='" + cbbGender.Text + "', Address='" + txtAddress.Text + "'WHERE Id ='" + txtID.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully ...!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = " SELECT *FROM tbl_insertion";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtFname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtAge.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cbbGender.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.Show();

          
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void photosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 photo = new Form4();
            photo.Show();
        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 desc = new Form3();
            desc.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
