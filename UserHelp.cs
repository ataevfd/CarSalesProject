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
using MySql.Data.MySqlClient;

namespace CarSalesProject2
{
    public partial class UserHelp : Form
    {

        MySqlConnection conn = new MySqlConnection("SERVER=LOCALHOST;DATABASE=carsales;UID=root;PASSWORD=fd2005");
        public UserHelp()
        {
            InitializeComponent();
        }

        private void UserHelp_Load(object sender, EventArgs e)
        {


           // MySqlDataAdapter da = new MySqlDataAdapter(fd, conn);

            //DataSet ds = new DataSet();

            //da.Fill(ds);

            //dataGridView1.DataSource = ds.Tables[0];



            /* try
             {
                 string fd = "select * from sales where carno=" + dataGridView1.SelectedCells[0].Value + " ";

                 MySqlDataAdapter da = new MySqlDataAdapter(fd, conn);

                 DataSet ds = new DataSet();

                 da.Fill(ds);

                 dataGridView1.DataSource = ds.Tables[0];






             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }
    }
}
