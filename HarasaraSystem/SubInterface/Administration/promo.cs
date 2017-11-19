using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Administration
{
   
    public partial class promo : UserControl
    {
        DBconnect dba = new DBconnect();
        string acno;
        string empid;
        double tot;

        public promo()
        {
            InitializeComponent();
            empload();
        }
        private static promo _instance;
        public static promo Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new promo();



                return _instance;

            }
        }
        public void empload()
        {

            string query = "select * from employee";


            dba.tableLoad(query, dataGridView1);
        }
        private void promo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            empid=dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string fn=dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string ln=dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            acno= dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            label4.Text = fn +" "+ ln;

            string q = "select basic_allowance from profession  where  job_id= '" + acno + "'";
            label6.Text= dba.getValue(q);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            


          string q1 = "insert into bonus  values ('"+empid+"','"+label6.Text +"','"+tot +"')";
            dba.InsertDeleteUpdate(q1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cs = Convert.ToDouble(label6.Text);

                double ns = Convert.ToDouble(textBox1.Text);
              
                if (textBox1.Text != "")
                {

                   // if (label8.Text != "")
                   // {
                         tot = cs * (ns / 100);
                        label8.Text = tot.ToString();
                  //  }
                  //  else
                  //  {
                  //      label8.Text = "";
                    if(textBox1.Text == "")
                    {
                        label8.Text = "";
                    }
//  }
                }
                else
                {
                    label8.Text = "";
                }
            


            }
            catch (Exception)
            {

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label6.Text = "";
            label8.Text = "";
            textBox1.Text = "";
        }
    }
}
