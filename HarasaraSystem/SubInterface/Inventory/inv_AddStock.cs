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

namespace BMS_harasara
{
    public partial class inv_AddStock : UserControl
    {
        private static inv_AddStock _instance;

        public static inv_AddStock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inv_AddStock();
                return _instance;
            }
        }
        public inv_AddStock()
        {
            InitializeComponent();
            fillcombo();
        }

        void fillcombo()
        {
            string qry = "Select * from warehouse;";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry,connst);
            MySqlDataReader reader;

            try
            {
                connst.Open();
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    string location = reader.GetString("location");
                    comboBox1.Items.Add(location);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "database error");   
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int itemId = int.Parse(textBox4.Text);
            int count = int.Parse(textBox2.Text);
            float price=float.Parse(textBox3.Text);
            string loc = (String)comboBox1.SelectedItem;
            String name=textBox1.Text;
            String ttype = "Receipt";

            String datenw = DateTime.Now.ToString();

            string qry = "Select * from inventory where item_id='"+itemId+"';";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry, connst);
            MySqlDataReader reader;

            
                connst.Open();
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    Int32 countt = reader.GetInt32("count");
                    float pricet = reader.GetFloat("price");

                    Int32 countf = countt + count;
                    float pricef = (pricet + price)/2;

                        try
                                    {
                                        String qry2 = "Insert into inv_trans(item_id,count,price,location,type,date) values('" + itemId + "','" + count + "','" + price + "','" + loc + "','" + ttype + "','"+datenw+"')";
                                        String qry1 = "Update inventory set count='"+countf+"',price='"+pricef+"',last_update='"+datenw+"' where (item_id='"+itemId+"'or name='"+name+"')and location='"+loc+"'";
                                        dbconnect conn = new dbconnect();
                                         
                                        conn.ExQuery(qry1);
                                        conn.ExQuery(qry2);

                                        MessageBox.Show("Entry Added Success");
                                        textBox1.Text = "";
                                        textBox2.Text="";
                                        textBox3.Text = "";
                                        textBox4.Text = "";
                                       
                                    }
                                    catch (Exception ex)
                                    {

                                        MessageBox.Show(ex.Message,"Check database connection");

                                        MessageBox.Show("Check database connection again");

                                    }
                    
                }
                
            
            

            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
            textBox4.AutoCompleteSource=AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll1=new AutoCompleteStringCollection();

            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            AutoCompleteStringCollection coll2=new AutoCompleteStringCollection();

            string qry = "Select * from inventory;";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry, connst);
            MySqlDataReader reader;

            try
            {
                connst.Open();
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    string itemid = reader.GetString("item_id");
                    coll1.Add(itemid);

                    string iname = reader.GetString("name");
                    coll2.Add(iname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"database error");
            }
            textBox4.AutoCompleteCustomSource=coll1;
            textBox1.AutoCompleteCustomSource = coll2;
            connst.Close();

            String loc = (String)comboBox1.SelectedItem;
            connst.Open();
            String qry3 = "SELECT * from inv_trans where location='"+loc+"' and type='Receipt' ";
            //MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=bms_harasaradb");
            MySqlCommand cmd2 = new MySqlCommand(qry3, connst);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dbdataset;
            dataGridView2.DataSource = bsource;
            sda.Update(dbdataset);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string theText = objTextBox.Text;
            String loc = (String)comboBox1.SelectedItem;
            string qry1 = "Select * from inventory where name = '" + theText + "'and location = '" + loc + "';";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry1, connst);
            MySqlDataReader reader;

            try
            {
                connst.Open();
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    string itemid = reader.GetString("item_id");
                    //coll1.Add(itemid);
                    textBox4.Text=itemid;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"database error");
            }
            //textBox4.AutoCompleteCustomSource=coll1;
            //textBox1.AutoCompleteCustomSource = coll2;
        
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            string theText = objTextBox.Text;
            String loc = (String)comboBox1.SelectedItem;
            string qry1 = "Select * from inventory where item_id = '" + theText + "' and location = '"+loc+"';";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry1, connst);
            MySqlDataReader reader;

            try
            {
                connst.Open();
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    string iname = reader.GetString("name");
                    //coll1.Add(itemid);
                    textBox1.Text = iname;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"database error");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        } 
    }
}
