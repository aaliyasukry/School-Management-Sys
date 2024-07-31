using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project__CSE_22._2___033_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cls_connection.Open_connection();
            MySqlCommand cmd = new MySqlCommand("Insert into student Values (@index_no,@name,@address,@contact)", cls_connection.con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@index_no",txtbox_ID.Text);
            cmd.Parameters.AddWithValue("@name", txtbox_name.Text);
            cmd.Parameters.AddWithValue("@address", txtbox_address.Text);
            cmd.Parameters.AddWithValue("@contact", txtbox_contact.Text);
            cmd.ExecuteNonQuery();
            cls_connection.Close_connection();
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cls_connection.Open_connection();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from student", cls_connection.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            dataGridView1.DataSource = ds.Tables["student"].DefaultView;
            cls_connection.Close_connection();
        }
    }
}
