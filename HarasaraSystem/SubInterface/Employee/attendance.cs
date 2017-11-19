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



    public partial class attendance : UserControl
    {
        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara; Convert Zero Datetime=True; ");

        private static attendance _instance;
        public static attendance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new attendance();

                return _instance;

            }
        }
        public attendance()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            connect.Open();

            MySqlDataAdapter view_t = new MySqlDataAdapter("select card_id,date,arrival_time,leave_time from attendancehistory" , connect);

            DataTable DT3 = new DataTable();

            view_t.Fill(DT3);
            dataGridView1.DataSource = DT3;
            //dataGridView1.Rows[0].Cells[0].Style.BackColor = Color.Red;



            MySqlDataAdapter view_t2 = new MySqlDataAdapter("select employee_id, card_id,fname,lname from employee  ", connect);

            DataTable DT4 = new DataTable();

            view_t2.Fill(DT4);
            dataGridView2.DataSource = DT4;

            connect.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }



    }
}
