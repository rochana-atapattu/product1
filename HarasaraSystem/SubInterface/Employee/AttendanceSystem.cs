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

namespace HarasaraSystem.SubInterface.Employee
{
    public partial class AttendanceSystem : Form
    {
        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara; Convert Zero Datetime=True; ");


        public AttendanceSystem()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text.Length == 10)
            {
                String date1 = DateTime.Now.ToString("yyyy-MM-dd");
                String time1 = DateTime.Now.ToString("h:mm:ss tt");

                textBox1.Text = date1;
                textBox3.Text = time1;

                DBAccess db = new DBAccess();
                string query = "INSERT INTO attendance(card_id,date,arrival_time) Values('" + this.textBox2.Text + "','" + this.textBox1.Text + "','" + this.textBox3.Text + "')";
                db.insertData(query);

                connect.Open();

                MySqlDataAdapter view_t = new MySqlDataAdapter("select card_id,date,arrival_time from attendance ", connect);

                DataTable DT3 = new DataTable();

                view_t.Fill(DT3);
                dataGridView1.DataSource = DT3;
                connect.Close();


            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox5.Text.Length == 10)
            {
                String time2 = DateTime.Now.ToString("h:mm:ss tt");
                textBox4.Text = time2;
                DBAccess db = new DBAccess();
                String query = "INSERT INTO leavetimetable(card_id,leave_time) Values('" + this.textBox5.Text + "','" + this.textBox4.Text + "')";
                db.insertData(query);
                MessageBox.Show("Thank You For Your Kind Service Today");



                String datenew = DateTime.Now.ToString("yyyy-MM-dd");

                connect.Open();

                MySqlCommand cmd2= connect.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT arrival_time FROM attendance where card_id='" + textBox5.Text + "'";
                object p = cmd2.ExecuteScalar();
                String time = Convert.ToString(p);


                connect.Close();





                DBAccess dbhistory = new DBAccess();
                String queryh = "INSERT INTO attendancehistory(card_id,date,arrival_time,leave_time) Values('" + this.textBox5.Text + "','"+datenew+"','"+time+"','" + this.textBox4.Text + "')";
                dbhistory.insertData(queryh);




                connect.Open();

                MySqlDataAdapter view_t = new MySqlDataAdapter("select a.card_id,a.date,a.arrival_time,l.leave_time from attendance a, leavetimetable l where a.card_id = l.card_id AND a.card_id='"+this.textBox5.Text+"'", connect);

                DataTable DT3 = new DataTable();

                view_t.Fill(DT3);
                dataGridView2.DataSource = DT3;
                connect.Close();


                DBAccess db1 = new DBAccess();
                string query1 = "delete from leavetimetable where card_id='" + this.textBox5.Text + "'";
                db1.insertData(query1);

                DBAccess db12 = new DBAccess();
                string query2 = "delete from attendance where card_id='" + this.textBox5.Text + "'";
                db1.insertData(query2);


                connect.Open();

                MySqlDataAdapter view_t2 = new MySqlDataAdapter("select card_id,date,arrival_time from attendance ", connect);

                DataTable DT34 = new DataTable();

                view_t2.Fill(DT34);
                dataGridView1.DataSource = DT34;
                connect.Close();




            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MainMenu reload = new MainMenu();
            reload.Show();
            Visible = false;
        }
    }
}
