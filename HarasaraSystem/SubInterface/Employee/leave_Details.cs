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
using System.Web;
namespace HarasaraSystem.SubInterface.Employee
{
    public partial class leave_Details : Form
    {

        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara; Convert Zero Datetime=True;");
        public leave_Details()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leave_Details_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            string query = "insert into harasara.leavehistory(e_id,first_name,last_name,designation,department,leave_requested_date,leave_submitted_date,type,period,reason,status) values ('" + this.label5.Text + "','" + this.label6.Text + "','" + this.label7.Text + "','" + this.label21.Text + "','" + this.label23.Text + "','" +   Convert.ToDateTime(label13.Text).ToString("yyyy-MM-dd")  + "','" + Convert.ToDateTime(label12.Text).ToString("yyyy-MM-dd") + "' ,'" + this.label14.Text + "' ,'" + this.label15.Text + "','" + this.label17.Text + "','" + HRSTATUS + "')";
            db.insertData(query);

            MessageBox.Show("Succesfully Submitted The Decision");

            DBAccess db1 = new DBAccess();
            string query1 = "delete from harasara.leaverecords where e_id='" + label5.Text + "'";
            db1.insertData(query1);

           
            //GET the status

        


          /*  connect.Open();
            string text;
            MySqlCommand cmd = connect.CreateCommand();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT status FROM leavehistory where e_id='" + label15.Text + "' HAVING MAX(leave_no)";
                object p = cmd.ExecuteScalar();
                text = p.ToString();
                label25.Text = text;
                connect.Close();
            }

            catch(Exception ex)
            {
                connect.Close();
                
            }
            */
            //send SMS




/*
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                try
                {
                    string url = "http://smsc.vianett.no/v3/send.ashx?" +
                                 "src=" + textBox1.Text + "&" +
                                 "dst=" + textBox1.Text + "&" +
                                 "msg=" + System.Web.HttpUtility.UrlEncode("Your leave request has been reviewed .Please meet the HR Manager ", System.Text.Encoding.GetEncoding("ISO-8859-1")) + "&" +
                                  "username=" + System.Web.HttpUtility.UrlEncode("hlktharushika@gmail.com") + "&" +
                                  "password=" + System.Web.HttpUtility.UrlEncode("w5ij4");
                    string result = client.DownloadString(url);
                    if (result.Contains("Ok"))
                    {
                        MessageBox.Show("Your message is succesfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Message sending failed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
            this.Close();

        }
        string HRSTATUS;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HRSTATUS = "Approved";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            HRSTATUS = "Rejected";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
