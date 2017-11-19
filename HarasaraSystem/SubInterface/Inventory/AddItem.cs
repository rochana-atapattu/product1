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
using System.Data;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Inventory
{
    public partial class AddItem : UserControl
    {
        private static AddItem _instance;

        public static AddItem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddItem();
                return _instance;
            }
        }
        public AddItem()
        {
            InitializeComponent();
            fillcombo();
        }

        void fillcombo()
        {
            string qry = "Select * from warehouse;";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry, connst);


            MySqlDataReader reader;

            try
            {
                connst.Open();
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    string location = reader.GetString("location");
                    comboBox3.Items.Add(location);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "database error");
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            String x = (String)comboBox5.SelectedItem;
            if (x == "Finished")
            {
                comboBox1.Items.Clear();

                string qry11 = "Select * from inventory_fd";

                MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
                MySqlCommand cmd1 = new MySqlCommand(qry11, connst);


                MySqlDataReader reader;

                try
                {
                    connst.Open();
                    reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        string proname1 = reader.GetString("productName");
                        comboBox1.Items.Add(proname1);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "database error");
                }

                textBox9.Text = "<Enter Price>";
            }
            else
            {
                comboBox1.Items.Clear();
                string qry = "Select * from inventory where type='" + x + "'";

                MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
                MySqlCommand cmd1 = new MySqlCommand(qry, connst);


                MySqlDataReader reader;

                try
                {
                    connst.Open();
                    reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        string proname = reader.GetString("name");
                        comboBox1.Items.Add(proname);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "database error");
                }

                textBox9.Text = "N/A";
            }

            

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                label14.Text = "Numbers only";
                e.Handled = true;
            }
            else
            {
                label14.Text = "";
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                label14.Text = "Numbers only";
                e.Handled = true;
            }
            else
            {
                label14.Text = "";
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                label15.Text = "Numbers only";
                e.Handled = true;
            }
            else
            {
                label15.Text = "";
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                label15.Text = "Numbers only";
                e.Handled = true;
            }
            else
            {
                label15.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x = (String)comboBox2.SelectedItem;
            
            BMS_harasara.dbconnect conn = new BMS_harasara.dbconnect();

            String prodID = textBox1.Text;
            String prodName = textBox2.Text;
            String Type = (String)comboBox2.SelectedItem;
            String rol = textBox3.Text;
            String min = textBox4.Text;
            String loca = (String)comboBox3.SelectedItem;
            String price = textBox8.Text;
            String cato = (String)comboBox4.SelectedItem;
            String metric=label18.Text;

            if (x == "Finished")
            {
                String qry = "Insert into inventory_fd(productID,ProductName,Catogory,Price,ROL,location) Values('" + prodID + "','" + prodName + "','" + cato + "','" + price + "','" + rol + "','" +loca+ "')";
                String qry1 = "Insert into finishedproducts(ProductID,productName,Category,Price) Values('" + prodID + "','" + prodName + "','" + cato + "','" + price + "')";

                try
                {
                    conn.ExQuery(qry);
                    conn.ExQuery(qry1);
                    MessageBox.Show("Inventory Item added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Check Database Connection");
                }
            }
            else
            {
                String qry3 = "Insert into inventory(name,rol,min,metric,type,location)Values('"+prodName+"','"+rol+"','"+min+"','"+metric+"','"+Type+"','"+loca+"')";
                try
                {
                    conn.ExQuery(qry3);
                    MessageBox.Show("Inventory Item added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Check Database Connection");
                }
            }
            
            /*string qry = "insert into inventory(item_id,name,type,rol,metric,min,location,item_pic) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.comboBox1.SelectedItem + "','" + this.textBox3
                .Text + "','" + this.comboBox3.SelectedItem + "','" + this.textBox4.Text + "','" + this.comboBox2.SelectedItem + "',@IMG)";
            BMS_harasara.dbconnect conn = new BMS_harasara.dbconnect();
            try
            {
                conn.ExQuery(qry);
                MessageBox.Show("Entry Added Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check Database Connection");
            }*/
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String x = (String)comboBox2.SelectedItem;
            if (x == "Finished")
            {
                textBox8.Text = "<Enter Price>";
                textBox1.Text="Enter ID";
            }
            else
            {
                textBox8.Text = "N/A";
                textBox1.Text="<Auto Generated>";

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                label14.Text = "Numbers only";
                e.Handled = true;
            }
            else
            {
                label14.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
