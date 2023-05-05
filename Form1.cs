using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Imaging;

namespace CarSalesProject2
{
    public partial class Form1 : Form
    {
        //for MySql & c# connection
        MySqlConnection conn=new MySqlConnection("SERVER=LOCALHOST;DATABASE=carsales;UID=root;PASSWORD=fd2005");
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1view_Click(object sender, EventArgs e)
        {
            viewgriddata();
        }

        void viewgriddata()
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //for to save the image
                MemoryStream memoryStream = new MemoryStream();
                pictureBox3.Image.Save(memoryStream, ImageFormat.Jpeg);

                byte[] photo_ary = new byte[0];
                photo_ary = new byte[memoryStream.Length];

                memoryStream.Position = 0;
                memoryStream.Read(photo_ary, 0, photo_ary.Length);

                MySqlCommand mySqlCommand = new MySqlCommand("insert into sales values  (" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + "," + textBox7.Text + ",'" + textBox8.Text + "','" + textBox10.Text + "','" + textBox9.Text + "',@photo    )", conn);

                mySqlCommand.Parameters.AddWithValue("@photo", photo_ary);

                //MySqlDataAdapter da = new MySqlDataAdapter("insert into sales values" + "("+textBox1.Text+",'"+textBox2.Text+"',"+textBox3.Text+","+textBox4.Text+","+textBox5.Text+","+textBox6.Text+","+textBox7.Text+",'"+textBox8.Text+"','"+textBox10.Text+"','"+textBox9.Text+"')", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);
                DataSet ds = new DataSet();

                da.Fill(ds);

                string name1 = textBox8.Text;
                string surname1 = textBox9.Text;
                string teln = textBox10.Text;
                if (name1 == "")
                {
                    MessageBox.Show("Enter the name");
                  
                    if (surname1 == "")
                    {
                        MessageBox.Show("Enter the surname");
                        
                        
                        if (teln == "" && teln.Length != 10)
                        {
                            MessageBox.Show("Enter the number correctly");
                        }
                    }
                }
                
                else
                {

                    MessageBox.Show("Your application has been approved !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f=new OpenFileDialog();
            if(f.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(f.FileName);
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
            }
        }
    }
}