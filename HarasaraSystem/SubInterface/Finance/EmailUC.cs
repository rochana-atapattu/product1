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
using System.Net.Mail;

namespace HarasaraSystem.SubInterface.Finance
{
    public partial class EmailUC : UserControl
    {
        private static EmailUC _einstance;
        public static EmailUC eInstance
        {
            get
            {
                if (_einstance == null)
                {
                    _einstance = new EmailUC();
                }
                return _einstance;
            }
        }
        public EmailUC()
        {
            InitializeComponent();
            textBox6.PasswordChar = '*';
        }

        private void EmailUC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text);
                SmtpClient client = new SmtpClient(textBox4.Text);
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(textBox5.Text, textBox6.Text);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Mail Sent!", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
