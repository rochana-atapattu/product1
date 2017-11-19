using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Sales
{
    public partial class setting : UserControl
    {
        private static setting _instance;

        public static setting Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new setting();
                return _instance;

            }
        }

        public setting()
        {
            InitializeComponent();
            databaseAccess d1 = new databaseAccess();
            d1.AutoCompleteText(textBox1,"select * from supplier","supplierName");
            d1.AutoCompleteText(textBox4, "select * from customer", "customerName");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into itemsandsupplier (SupID,ItemNo,ItemDescription) values ('"+textBox6.Text+"','"+label10.Text+"','"+comboBox1.Text+"') ";
            string query2="select * from itemsandsupplier";

            databaseAccess d1 = new databaseAccess();
            d1.InsertData(query);
            d1.displayData(query2, dataGridView1);
           
        }

        private void setting_Load(object sender, EventArgs e)
        {
            databaseAccess d2 = new databaseAccess();
            d2.ComboBoxLoad("name",comboBox1, "select * from inventory");


         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select item_id from harasara.inventory where name='" + comboBox1.Text + "'";
            databaseAccess d1 = new databaseAccess();
            label10.Text=d1.getString(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomMsgBox.Show("  Completed ", "OK");

            textBox6.Text = null;
            textBox1.Text = null;
            textBox2.Text = null;
            richTextBox2.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
            textBox7.Text = null;
            label10.Text = "XXXXXXX";
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE supplier SET  supplierName='"+textBox1.Text+"', contactNumber='"+textBox2.Text+"', Address='"+richTextBox2.Text+"',Bank='"+comboBox2.Text+"',AccountNumber='"+textBox7.Text+"' where SupID='"+textBox6.Text+"'";
            databaseAccess d1 = new databaseAccess();
            d1.InsertData(query);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            databaseAccess d1 = new databaseAccess();

            string query = "select count(*) from supplier where supplierName='" + textBox1.Text + "'";
            if (1==(d1.getValue(query)))
            {
            string supID = "select SupID from supplier  where supplierName='"+textBox1.Text+"'";
            string contactNumber = "select contactNumber from supplier  where supplierName='" + textBox1.Text + "'";
            string Address= "select Address from supplier  where supplierName='" + textBox1.Text + "'";
            string Bank = "select Bank from supplier where supplierName='" + textBox1.Text + "'";
            string AccountNumber = "select AccountNumber from supplier  where supplierName='" + textBox1.Text + "'";
            
            textBox6.Text = d1.getString(supID);
            textBox2.Text = d1.getString(contactNumber);
            richTextBox2.Text = d1.getString(Address);
            comboBox2.Text = d1.getString(Bank);
            textBox7.Text = d1.getString(AccountNumber);
             
            string query2="select * from itemsandsupplier where  SupID='"+textBox6+"'";
            d1.displayData(query2, dataGridView1);
         

            }
            else
            {
                textBox6.Text = null;
                textBox2.Text = null;
                richTextBox2.Text = null;
                comboBox2.Text = null;
                textBox7.Text = null;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = null;
            textBox1.Text = null;
            textBox2.Text = null;
            richTextBox2.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
            textBox7.Text = null;
            label10.Text = "XXXXXXX";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string query="select count(*) from customer where customerName='"+textBox4.Text+"'";
            databaseAccess d1 = new databaseAccess();
            if(1  ==(d1.getValue(query)))
            {
                string ID = "select customerID from customer where customerName='"+textBox4.Text+"'";
                string number = "select contactNumber from customer where customerName='"+textBox4.Text+"'";
                string Address = "select Address from customer where customerName='"+textBox4.Text+"'";

                textBox3.Text = d1.getString(ID);
                textBox5.Text = d1.getString(number);
                richTextBox1.Text = d1.getString(Address);

            }
            else
            {
                textBox3.Text = null;
                textBox5.Text = null;
                richTextBox1.Text = null;
            }
        }
    }
}
