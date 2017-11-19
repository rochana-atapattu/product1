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
    public partial class SystemAdmins : UserControl
    {
        DBconnect d1 = new DBconnect();
        private static SystemAdmins _instance;
        string a;
        public static SystemAdmins Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new SystemAdmins();
                return _instance;

            }
        }
        public SystemAdmins()
        {
            InitializeComponent();
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            string query = "insert into admins(Name,Username,Password,Position,Email,ContactNumber) values ('" + name.Text + "','" + username.Text + "','" + password.Text + "','" + position.Text + "','" + email.Text + "','" + Convert.ToInt32(contactnumber.Text) + "')";
         
          d1.InsertDeleteUpdate(query);
            admintab();
        }
        public void admintab()
        {
            string query = "select * from admins";

          
          d1.tableLoad(query, dataGridView1);
        }
        private void SystemAdmins_Load(object sender, EventArgs e)
        {

            admintab();
           
        }

        private void contactnumber_Leave(object sender, EventArgs e)
        {
           /* textBoxValidations t1 = new textBoxValidations();
            t1.ContcatNumber(contactnumber.Text, label8);*/
        }

        private void email_Leave(object sender, EventArgs e)
        {
           /* textBoxValidations t1 = new textBoxValidations();
            t1.Email(email.Text, label9);*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string q = "delete from admins where `Index`='"+a+"'";
            
            d1.InsertDeleteUpdate(q);
            admintab();
        }

        private void position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "update admins set Name='" + name.Text + "', Username='" + username.Text + "', Password='" + password.Text + "' ,Position='" + position.Text+ "' 	,Email='" + email.Text + "' , ContactNumber='" + Convert.ToInt32(contactnumber.Text) + "' where `Index`='" + a + "' ";
                d1.InsertDeleteUpdate(q);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            admintab();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void email_Validated(object sender, EventArgs e)
        {
             string mail = email.Text;
            if (mail.IndexOf("@") != -1 && mail.IndexOf(".com") != -1)
            {
                if (mail.IndexOf("@") > mail.IndexOf(".com"))
                {

                    // MessageBox.Show("Please Insert valid Email");
                    email.BackColor = Color.Red;
                    email.Text = "please enter vaild mail";
                    //mail.Text = string.Empty;
                }
                else
                {

                    email.BackColor = Color.White;
                }
             
            }
            else {
                email.BackColor = Color.Red;
                email.Text = "please enter vaild mail";
               
            }

        
        }

        private void contactnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           a = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            name.Text=dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
             username.Text=dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            password.Text=dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            position.SelectedText=dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            email.Text=dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            contactnumber.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

           // i = Convert.ToInt32(a);
        }

        private void nam_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from admins where Name like '%"+nam.Text+"%'";


            d1.tableLoad(query, dataGridView1);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
