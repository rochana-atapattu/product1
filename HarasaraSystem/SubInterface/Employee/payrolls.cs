using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace HarasaraSystem.SubInterface.Employee
{
    public partial class payrolls : UserControl
    {
        private static payrolls _instance;
        public static payrolls Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new payrolls();

                return _instance;

            }
        }

       MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara; Convert Zero Datetime=True;");
      // MySqlCommand cmd3;
        public payrolls()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           int nlm = 10;
            label10.Text = nlm.ToString();
            int leavecount, exl;
            double OT, OT2, sal, netsal;

            connect.Open();

            MySqlCommand cmd1 = connect.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT COUNT(e_id) FROM leavehistory where e_id='" + textBox1.Text + "'";
            object o = cmd1.ExecuteScalar();
            leavecount = Convert.ToInt32(o);

            //------------------------------------------------------------------------------------

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select p.OT_rate from profession  p, employee e where e.position=p.job_id AND e.employee_id='" + this.textBox1.Text + "' ";
            object p = cmd.ExecuteScalar();
            OT = Convert.ToInt32(p);
         
            //---------------------------------------------------------------------------------------

            MySqlCommand command1 = connect.CreateCommand();
            command1 = connect.CreateCommand();
            OT2 = OT * Convert.ToInt32(this.textBox2.Text);
            // --------------------------------------------------------------

            MySqlCommand cmd2 = connect.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select p.basic_allowance from profession  p, employee e where e.position=p.job_id AND e.employee_id='" + this.textBox1.Text + "' ";
            object basic = cmd2.ExecuteScalar();
            sal = Convert.ToInt32(basic);
            

            label22.Text = sal.ToString();
            label23.Text = OT2.ToString();
            command1.CommandType = CommandType.Text;


            //calculating final net salary
            netsal = sal + OT2;
            label21.Text = netsal.ToString();


            //leavecount



            exl = nlm - leavecount;
            label12.Text = exl.ToString();


            MySqlCommand command = connect.CreateCommand();
            command = connect.CreateCommand();
            command.CommandText = "select b.b_name,e.acc_no,COUNT(lr.e_id) from employee e, bank b , leavehistory lr where e.bank=b.b_id AND lr.e_id=e.employee_id AND lr.e_id = '" + textBox1.Text + "'";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                label8.Text = reader.GetString(0).ToString();
                label9.Text = reader.GetString(1).ToString();
                label11.Text = reader.GetString(2).ToString();
                string output = reader.ToString().ToString();
            }
            reader.Close();
            connect.Close();

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        public void clearall()
        {

            textBox1.Text = "";
            textBox2.Text = "";
            label8.Text = "";
            label9.Text = "";
            label11.Text = "";
            label12.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label10.Text = ""; 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBAccess dc = new DBAccess();
            string q = "insert into salary (e_id,netsalary) values ('" + textBox1.Text + "','" + label21.Text + "')";
            dc.insertData(q);
            MessageBox.Show("Succesfully Submitted");
            clearall();
        }
    }
}
