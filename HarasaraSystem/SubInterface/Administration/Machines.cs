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


namespace HarasaraSystem.SubInterface.Administration
{
    public partial class Machines : UserControl

    {
      

        DBconnect dba = new DBconnect();
        string id;
        
        private static Machines _instance;
        public static Machines Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Machines();



                return _instance;

            }
        }
    
        public Machines()
        {
            InitializeComponent();
        }
        public void machinetble()
        {

            string query = "select * from machines";

       
            dba.tableLoad(query, data1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into machines(machineid, description, price, currentdate,toberesturned, status) values ('" + Convert.ToInt32(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyy/MM/dd") + "','" + dateTimePicker2.Value.Date.ToString("yyyy/MM/dd")+"','" + status + "')";
          
            dba.InsertDeleteUpdate(query);
            machinetble();
        }

        private void Machines_Load(object sender, EventArgs e)
        {
          //  machinetble();
        }


        private void button4_Click(object sender, EventArgs e)
        {
           
           try
           {
               string q = "delete from machines where machineid='" + id + "'";
               dba.InsertDeleteUpdate(q);
           }
            catch(Exception e1){

                MessageBox.Show(e1.ToString());
            }
            machinetble();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        string status;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            status = "Repair";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            status = "Purchase";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            status = "Normal";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Machines_Load_1(object sender, EventArgs e)
        {
            machinetble();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void data1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = data1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string q = "select * from machines where machineid like '%" + textBox4.Text + "%'";


            dba.tableLoad(q, data1);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
