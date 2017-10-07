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
using HarasaraSystem.SubInterface.Sales;

namespace HarasaraSystem
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
        MySqlCommand cmd;
        public Login(string ptn)
        {
            InitializeComponent();

            position.Text = ptn;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select count(*) from admins where Username='" + textBox1.Text + "'  and  Password='" + textBox2.Text + "' and Position='" + position.Text + "'";
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                int x = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                if (x==1)
                {
                    SalesSub s1 = new SalesSub(textBox1.Text);
                    s1.Show();
                    this.Hide();
                }
                else
                {
                    label4.Text = "Username or Password is incorrect";
                    label4.ForeColor = Color.Red;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MainMenu m1 = new MainMenu();
            m1.Show();
            this.Hide();
        }
    }
}
