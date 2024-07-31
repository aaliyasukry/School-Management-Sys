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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtBox_username.Text == "aaliya.sukry")
            {
                if (txtBox_pass.Text == "Pass@123.")
                {
                    this.Hide();
                    MessageBox.Show("Successfully Logged in!");
                    Form3 f3 = new Form3();
                    f3.Show();
                }

                else
                {
                    MessageBox.Show("Incorrect Password !");
                }
            }

            else
            {
                MessageBox.Show("Incorrect Username !");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
