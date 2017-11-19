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

namespace HarasaraSystem.SubInterface.Employee
{
    public partial class SMS : UserControl
    {

        private static SMS _instance;
        public static SMS Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SMS();

                return _instance;

            }
        }

        public SMS()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using(System.Net.WebClient client=new System.Net.WebClient())
            {
                try
                {
                    string url = "http://smsc.vianett.no/v3/send.ashx?" +
                                 "src=" + textBox3 .Text+ "&" +
                                 "dst="+textBox3.Text+"&" +
                                 "msg=" +System.Web.HttpUtility.UrlEncode(textBox4.Text,System.Text.Encoding.GetEncoding("ISO-8859-1"))+"&"+
                                  "username=" + System.Web.HttpUtility.UrlEncode(textBox1.Text) + "&" +
                                  "password="+System.Web.HttpUtility.UrlEncode(textBox2.Text);
                    string result = client.DownloadString(url);
                    if (result.Contains("Ok"))
                    {
                        MessageBox.Show("Your message sending failed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Message successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }
    }
}
