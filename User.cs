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

namespace CarSalesProject2
{
    public partial class User : Form
    {

        MySqlConnection conn = new MySqlConnection("SERVER=LOCALHOST;DATABASE=carsales;UID=root;PASSWORD=fd2005");
        public User()
        {
            InitializeComponent();
        }

        void fd()
        {
            try
            {

                MySqlDataAdapter da = new MySqlDataAdapter("select * from sales", conn);

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
           fd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                //  for Deleted
                string delete = "delete from sales where carno = " + dataGridView1.SelectedRows[0].Cells[0].Value + " ";

                MySqlDataAdapter da = new MySqlDataAdapter(delete, conn);

                DataSet ds = new DataSet();

                da.Fill(ds);

                MessageBox.Show("Deleted succesfully","WARNING",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

               fd();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
