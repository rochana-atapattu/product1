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
    public partial class leaverequest : Form
    {
        public leaverequest()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database =harasara");
        
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu back = new MainMenu();
            back.Show();
            Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please Fill The Required Details");

            }

            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please Fill The Type Of Your Leave");
            }

            else if (!radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked && !radioButton6.Checked && !radioButton7.Checked && !radioButton8.Checked)
            {
                MessageBox.Show("Please Fill The Reason For Your Leave"); 
            }
            else
            {
                int eid;
                MySqlCommand cmd1 = new MySqlCommand("SELECT employee_id FROM employee where employee_id='" + textBox1.Text + "'", connect);
                MySqlCommand cmd;



                try
                {
                    connect.Open();
                    eid = (Int32)cmd1.ExecuteScalar();

                    cmd = connect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into harasara.leaverecords(e_id,requested_date,submitted_date,Type,period,Reason) values ('" + eid + "','" + dateTimePicker1.Value.Date.ToString("yyyy/MM/dd") + "','" + dateTimePicker2.Value.Date.ToString("yyyy/MM/dd") + "','" + TYPE + "','" + this.textBox4.Text + "','" + REASON + "')";

                    cmd.ExecuteNonQuery();


                    connect.Close();

                    MessageBox.Show("Your Request Is Succesfully Submitted");
                    clear();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        String REASON;
        String TYPE;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TYPE = "Half Day";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TYPE = "Full Day";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Sick";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Unpaid";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Personal Leave";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Maternity/Paternity";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Bereavement";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            REASON = "Other"; 
        }


        public void clear()
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    textBox1.Text = "";
                    textBox4.Text = "";
                    
                }



                 if (c is DateTimePicker)
                {
                    dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                }


                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }

                

            }

            foreach (Control c in groupBox1.Controls)
            {

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }

            }

        }

    }
}
