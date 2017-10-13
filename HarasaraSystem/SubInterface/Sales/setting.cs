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
            d1.AutoCompelte(textBox6, "select * from harasara.supplier", "SupID");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into harasara.itemsandsupplier (SupID,ItemNo,ItemDescription) values ('"+textBox6.Text+"','"+Convert.ToInt32(comboBox1.Text)+"','"+label10.Text+"')";
            string query1="select * from harasara.itemsandsupplier";
            databaseAccess d1 = new databaseAccess();
            d1.InsertData(query);
            d1.displayData(query1, dataGridView1);

        }

        private void setting_Load(object sender, EventArgs e)
        {
            string query = "select * from harasara.inventory ";

            databaseAccess d1 = new databaseAccess();
            d1.ComboBoxLoad("item_id", comboBox1, query);

         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select name from harasara.inventory where item_id='" + comboBox1.Text + "'";
            databaseAccess d1 = new databaseAccess();
            label10.Text=d1.getString(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            databaseAccess d1 = new databaseAccess();
            string query1="select count(*) from harasara.supplier where SupID='"+textBox6.Text+"'";

            if (0 == d1.getValue(query1))
            {




                string query = "insert into harasara.supplier (SupID,supplierName,contactNumber,Address,Bank,AccountNumber) values ('" + textBox6.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + richTextBox2.Text + "','"+comboBox2.Text+"','"+textBox7.Text+"')";


                d1.InsertData(query);
                CustomMsgBox.Show("Added New Supplier ", "OK");

            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char x = e.KeyChar;

            if(x != 8)
            {
                
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            databaseAccess d1 = new databaseAccess();
            string query0 = "select count(*) from harasara.supplier where SupID='" + textBox6.Text + "'";
            if (1 == d1.getValue(query0))
            {
                string query = "select supplierName from harasara.supplier where SupID='" + textBox6.Text + "'";
                string query1 = "select contactNumber from harasara.supplier where SupID='" + textBox6.Text + "'";
                string query2 = "select Address from harasara.supplier where SupID='" + textBox6.Text + "'";
                string query3 = "select Bank from harasara.supplier where SupID='" + textBox6.Text + "'";
                string query4 = "select AccountNumber from harasara.supplier where SupID='" + textBox6.Text + "'";

                textBox1.Text = d1.getString(query);
                textBox2.Text = d1.getString(query1);
                comboBox2.Text = d1.getString(query3);
                textBox7.Text = d1.getString(query4);
                richTextBox2.Text = d1.getString(query2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            databaseAccess d1 = new databaseAccess();
           string query = "update harasara.supplier set (supplierName='"+textBox1.Text+"',contactNumber='"+textBox2.Text+"',Address='"+richTextBox2.Text+"',Bank='"+comboBox2.Text+"',AccountNumber='"+textBox7.Text+"')";
           d1.InsertData(query);
        }
    }
}
