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
using System.IO;

namespace HarasaraSystem.SubInterface.Employee
{
    public partial class search : UserControl
    {

        private static search _instance;
        public static search Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new search();

                return _instance;

            }
        }

        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara; Convert Zero Datetime=True; ");
        public search()
        {
            InitializeComponent();
        }
        private Image originalImage;
        private void search_Load(object sender, EventArgs e)
        {
            originalImage = pictureBox1.Image;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            string query = "select image from harasara.employee where employee_id='" + this.textBox1.Text + "'";
            
            MySqlCommand cmdDataBase = new MySqlCommand(query, connect);
            MySqlDataReader myReader;

            try
            {
                connect.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["image"]);
                    if (imgg == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }


                }

                connect.Close();
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect.Open();
            MySqlCommand command = connect.CreateCommand();
            command = connect.CreateCommand();
           
            command.CommandText = "select e.fname,e.lname,e.address,e.email,e.gender,e.mobile_no,e.home_phone_no,e.acc_no,b.b_name from employee e , bank b where e.bank=b.b_id AND e.employee_id='" + textBox1.Text + "'";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                label15.Text = reader.GetString(0).ToString();
                label16.Text = reader.GetString(1).ToString();
                label17.Text = reader.GetString(2).ToString();
                label18.Text = reader.GetString(3).ToString();
                label19.Text = reader.GetString(4).ToString();
                label20.Text = reader.GetString(5).ToString();
                label21.Text = reader.GetString(6).ToString();
                label22.Text = reader.GetString(7).ToString();
                label23.Text = reader.GetString(8).ToString();
                string output = reader.ToString().ToString();
            }
            reader.Close();
            connect.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            connect.Open();
            MySqlCommand command = connect.CreateCommand();
            command = connect.CreateCommand();

            
            command.CommandText = " select p.p_name,e.joined_date,d.dname from profession p, employee e, department d where e.position=p.job_id AND e.department_name=d.did AND e.employee_id='" + textBox1.Text + "'";

        
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();
          
            while (reader.Read())
            {
                label24.Text = reader.GetString(0).ToString();
                label25.Text = reader.GetDateTime(1).ToShortDateString();
                label26.Text = reader.GetString(2).ToString();
                string output = reader.ToString().ToString();

            }
            reader.Close();
            connect.Close();

            

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            connect.Open();
            
            MySqlDataAdapter view_t = new MySqlDataAdapter("select employee_id AS 'Employee ID' from employee ", connect);
            DataTable DT3 = new DataTable();

            view_t.Fill(DT3);
            dataGridView1.DataSource = DT3;
            connect.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            label25.Text = "";
            label26.Text = "";
            pictureBox1.Image = originalImage; 
        }

        private void dataGridView1_DefaultCellStyleChanged(object sender, EventArgs e)
        {

        }
    }
}
