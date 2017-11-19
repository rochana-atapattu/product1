using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;


namespace Transport
{
    public partial class SMS : Form
    {
       
        public SMS(string user)
        {
            InitializeComponent();
            timer1.Start();
            label7.Text = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();

                
                dt = db.ReadValue("Select employee_id,fname,mobile_no From employee");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message, "Error");




            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();


                dt = db.ReadValue("Select DriverID,DriverName,ContactNo From driverdetails");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message, "Error");




            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > -1)
            {
                
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                try
                {
                    string url = "http://smsc.vianett.no/v3/send.ashx?" +
                                 "src=" + textBox1.Text + "&" +
                                 "dst=" + textBox1.Text + "&" +
                                 "msg=" + System.Web.HttpUtility.UrlEncode(bunifuCustomTextbox2.Text, System.Text.Encoding.GetEncoding("ISO-8859-1")) + "&" +
                                  "username=" + System.Web.HttpUtility.UrlEncode("lithirafiverr@gmail.com") + "&" +
                                  "password=" + System.Web.HttpUtility.UrlEncode("p2dqo");
                    string result = client.DownloadString(url);
                    if (result.Contains("Ok"))
                        MessageBox.Show("Message send failure.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Your message has been succcesfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            
        private void bunifuThinButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main(label7.Text);
            m1.ShowDialog();
            this.Close();

        }

        private void SMS_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton6_Click(object sender, EventArgs e)
        {
            HarasaraSystem.MainMenu mm = new HarasaraSystem.MainMenu();
            this.Hide();
            mm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();


                dt = db.ReadValue("Select customerID,CustomerName,contactNumber From customer");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        
    }
}
