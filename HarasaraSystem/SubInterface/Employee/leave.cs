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
    public partial class leave : UserControl
    {

        private static leave _instance;
        public static leave Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new leave();

                return _instance;

            }
        }
        public leave()
        {
            InitializeComponent();
        }

        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara; Convert Zero Datetime=True; ");
        private void button2_Click(object sender, EventArgs e)
        {

            connect.Open();
            MySqlDataAdapter view_t = new MySqlDataAdapter("select l.approval ,e.employee_id AS 'employee id',e.fname AS 'first name',e.lname AS 'last name',p.p_name AS 'Designation',d.dname  AS 'Department',l.requested_date 'Leave Requested Date',l.submitted_date AS 'Request Submitted Date',l.Type,l.period,l.Reason,e.mobile_no from employee e, leaverecords l, department d, profession p where e.employee_id=l.e_id AND e.department_name=d.did AND e.position=p.job_id", connect);
            //MySqlDataAdapter view_t = new MySqlDataAdapter("select e.employee_id , l.period from employee e , leaverecords l where e.employee_id=l.e_id ", connect);
            DataTable DT3 = new DataTable();

            //DataTable DT3 = new DataTable();

            view_t.Fill(DT3);
            dataGridView1.DataSource = DT3;
            connect.Close();

            /*view_t.Fill(DT3);
            dataGridView1.DataSource = DT3;
            int n = 0;
            foreach (DataRow item in DT3.Rows)
            {

                dataGridView1.Rows[n].Cells[0].Value = false;
                n++;

            }
            connect.Close();*/


           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           leave_Details ld = new leave_Details();
            //ld.label19.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ld.label5.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ld.label6.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ld.label7.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ld.label21.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //ld.label25.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ld.label23.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            DateTime date1  = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[6].Value.ToString());
            ld.label13.Text = date1.ToShortDateString();
            DateTime date2 = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[7].Value.ToString());
            ld.label12.Text = date2.ToShortDateString(); 

            ld.label14.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            ld.label15.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            ld.label17.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            ld.textBox1.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString(); 
         //   ld..Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
          //  ld.textBox10.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            ld.ShowDialog(); 
        }
    }
}
;