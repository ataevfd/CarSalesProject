using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSalesProject2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string usern = "car";
            const string pass = "12345";

            string user1 = textBox1.Text;
            string pass1 = textBox2.Text;

            

            if (user1 == "")
            {
                MessageBox.Show("username was not included","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Error);


                if (pass1 == "")
                {
                    MessageBox.Show("password was not included");
                }
            }
            else
            {

                if (usern == user1 && pass == pass1)
                {
                    User u = new User();
                    u.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("The information entered is incorrect","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "UserName")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "UserName";
                textBox1.ForeColor= Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fu = new Form2();
            fu.ShowDialog();
            this.Hide();
        }
    }
}
