using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarSalesProject2
{
    public partial class Sales : Form
    {
        // MySql & c# connection
        MySqlConnection conn = new MySqlConnection("SERVER=LOCALHOST;DATABASE=carsales;UID=root;PASSWORD=fd2005");

        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            try
            {
                button2.Hide();

                MySqlDataAdapter da = new MySqlDataAdapter("select carno,model,price,photo from sales", conn);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               // for show information

               string fd = "select * from sales where carno=" + dataGridView1.SelectedCells[0].Value + " ";

                MySqlDataAdapter da = new MySqlDataAdapter(fd, conn);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                button1.Hide();
                label1.Hide();
                label3.Hide();
                label4.Hide();
                textBox1.Hide();
                textBox2.Hide();
                button3.Hide();
               button2.Show();
                label2.Show();

                label2.Text = "  -Suretler qutusu: Avtomat             -Oturucu: Tam\n  -Yeni: Xeyr                                         -Sahibler: 1\n  -Ban novu: SUV                                -Yerlerin sayi: 4\n  -Muherrik: 4.0                                  -Resmi diler" ;                    
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Hide();
               button1.Show();
                label1.Show();
                label2.Hide();
                label3.Show();
                label4.Show();
                textBox1.Show();
                textBox2.Show();
                button3.Show();
                pictureBox1.Show();
                linkLabel1.Show();
                pictureBox2.Show();
                linkLabel2.Show();
                linkLabel3.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                linkLabel4.Show();

                MySqlDataAdapter da = new MySqlDataAdapter("select carno,model,price from sales", conn);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Enter a filter", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from sales where model='" + textBox1.Text + "' ", conn);

                    DataSet ds = new DataSet();

                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (textBox1.Text == "")
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from sales where price <= " + textBox2.Text + " and price > 0 ", conn);

                    DataSet ds = new DataSet();

                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from sales where price <= " + textBox2.Text + " and price > 0 and model='" + textBox1.Text + "'", conn);

                    DataSet ds = new DataSet();

                    da.Fill(ds);
                  
                    dataGridView1.DataSource = ds.Tables[0];
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            label2.Text = "  -Suretler qutusu: Avtomat             -Oturucu: Tam\n  -Yeni: Xeyr                                         -Sahibler: 1\n  -Ban novu: SUV                                -Yerlerin sayi: 4\n  -Muherrik: 4.0                                  -Resmi diler";

            button2.Show();
            button1.Hide();
            label1.Hide();
            label2.Show();
            label3.Hide();
            label4.Hide();
            textBox1.Hide();
            textBox2.Hide();
            button3.Hide();
            linkLabel2.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide(); pictureBox4.Hide();
            linkLabel3.Hide();
            linkLabel4.Hide();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from sales where carno=1", conn);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            label2.Text = "  -Suretler qutusu: Avtomat             -Oturucu: Tam\n  -Yeni: Xeyr                                         -Sahibler: 1\n  -Ban novu: SUV                                -Yerlerin sayi: 4\n  -Muherrik: 4.0                                  -Resmi diler";

            button2.Show();
            button1.Hide();
            label1.Hide();
            label2.Show();
            label3.Hide();
            label4.Hide();
            textBox1.Hide();
            textBox2.Hide();
            button3.Hide();
            linkLabel1.Hide();
            pictureBox1.Hide();
            pictureBox3.Hide();pictureBox4.Hide();
            linkLabel3.Hide();
            linkLabel4.Hide();
            
          
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from sales where carno=2", conn);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Text = "  -Suretler qutusu: Avtomat             -Oturucu: Tam\n  -Yeni: Xeyr                                         -Sahibler: 1\n  -Ban novu: SUV                                -Yerlerin sayi: 4\n  -Muherrik: 4.0                                  -Resmi diler";
            pictureBox2.Hide();
            linkLabel4.Hide ();
            pictureBox4.Hide();
            linkLabel2.Hide();
            button2.Show();
            button1.Hide();
            label1.Hide();
            label2.Show();
            label3.Hide();
            label4.Hide();
            textBox1.Hide();
            textBox2.Hide();
            button3.Hide();
            linkLabel1.Hide();
            pictureBox1.Hide();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from sales where carno=3", conn);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Text = "  -Suretler qutusu: Avtomat             -Oturucu: Tam\n  -Yeni: Xeyr                                         -Sahibler: 1\n  -Ban novu: SUV                                -Yerlerin sayi: 4\n  -Muherrik: 4.0                                  -Resmi diler";
            pictureBox2.Hide();
            pictureBox4.Hide();
            linkLabel2.Hide();
            button2.Show();
            button1.Hide();
            label1.Hide();
            label2.Show();
            label3.Hide();
            label4.Hide();
            textBox1.Hide();
            textBox2.Hide();
            button3.Hide();
            linkLabel1.Hide();
            pictureBox1.Hide();
            pictureBox3.Hide();
            linkLabel3.Hide();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from sales where carno=5", conn);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VIP etmek aktiv deyildir","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
    

}




