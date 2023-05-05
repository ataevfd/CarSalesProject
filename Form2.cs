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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            f.ShowDialog();
           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales s=new Sales();
            s.ShowDialog();
            Form2 f=new Form2();
            f.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f=new Form3();
            f.ShowDialog();
        }
    }
}
