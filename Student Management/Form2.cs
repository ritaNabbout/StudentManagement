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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=StudentManagment;Integrated Security=True");

        private void checkAvCourse_ItemsCheckd(object sender, ItemCheckEventArgs e)
        {
            string item = checkAvCourse.SelectedItem.ToString();

            if (e.NewValue == CheckState.Checked)
                listBox1.Items.Add(item);

            con.Open();
            String query = "INSERT INTO tbl_registration(Id,Rcourse) VALUES ('" + txtStId.Text + "','" + checkAvCourse.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            
            
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtStId.Clear();
            listBox1.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = " SELECT *FROM tbl_registration";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM tbl_registration WHERE Id='" + txtStId.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Canceled successfuly !!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtStId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            listBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
