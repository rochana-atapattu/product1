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
    public partial class inv_FinishStock : UserControl
    {
        private static inv_FinishStock _instance;

        public static inv_FinishStock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inv_FinishStock();
                return _instance;
            }
        }
        public inv_FinishStock()
        {
            InitializeComponent();
            fillcombo();
        }

        void fillcombo()
        {
            String qry = "Select * From warehouse";
            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry, connst);
            MySqlDataReader reader;

            comboBox1.Text = "<Select Warehouse>";
            comboBox2.Text = "<Select Warehouse>";
            try
            {
                connst.Open();
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    string location = reader.GetString("location");
                    comboBox1.Items.Add(location);
                    comboBox2.Items.Add(location);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "database error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String loc = (String)comboBox1.SelectedItem;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll2 = new AutoCompleteStringCollection();

            string qry = "Select * from inventory_fd where location='"+loc+"';";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry, connst);
            MySqlDataReader reader;

            try
            {
                connst.Open();
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    
                    string iname = reader.GetString("productID");
                    coll2.Add(iname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "database error");
            }
            
            textBox1.AutoCompleteCustomSource = coll2;
            connst.Close();

            connst.Open();
            String qry3 = "SELECT * from fd_trans where location='" + loc + "' and type='Receipt' ";
            //MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=bms_harasaradb");
            MySqlCommand cmd2 = new MySqlCommand(qry3, connst);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd2;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dbdataset;
            dataGridView1.DataSource = bsource;
            sda.Update(dbdataset);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String prodid = textBox1.Text;
            int count = int.Parse(textBox2.Text);
            String loc = (String)comboBox1.SelectedItem;
            String typet = "Receipt";
            String datenw = DateTime.Now.ToString();

            String qry = "Select * from inventory_fd where productID='" + prodid + "'";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry, connst);
            MySqlDataReader reader;

            connst.Open();
                reader = cmd1.ExecuteReader();
                //while (reader.Read())
                //{
                reader.Read();
                    Int32 countt = reader.GetInt32("Count");
                    Int32 countf = countt + count;

                    try
                    {
                        String qry2 = "Insert into fd_trans(productID,count,location,type,date) values('" + prodid + "','" + count + "','" + loc + "','" + typet + "','" + datenw + "')";
                        String qry1 = "Update inventory_fd set count='" + countf + "' where productID='" + prodid + "'and location='" + loc + "'";
                        dbconnect conn = new dbconnect();

                        conn.ExQuery(qry1);
                        conn.ExQuery(qry2);

                        textBox1.Text = "";
                        textBox2.Text = "";

                        MessageBox.Show("Entry Added");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Check database connection");
                    }
                //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String prodid = textBox3.Text;
            int count = int.Parse(textBox4.Text);
            String loc = (String)comboBox2.SelectedItem;
            String typet = "Issue";
            String datenw = DateTime.Now.ToString();

            String qry = "Select * from inventory_fd where productID='" + prodid + "'";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry, connst);
            MySqlDataReader reader;

            connst.Open();
            reader = cmd1.ExecuteReader();
            //while (reader.Read())
            //{
            reader.Read();
                Int32 countt = reader.GetInt32("Count");
                Int32 countf = countt - count;

                try
                {
                    String qry2 = "Insert into fd_trans(productID,count,location,type,date) values('" + prodid + "','" + count + "','" + loc + "','" + typet + "','" + datenw + "')";
                    String qry1 = "Update inventory_fd set count='" + countf + "' where productID='" + prodid + "'and location='" + loc + "'";
                    dbconnect conn = new dbconnect();

                    conn.ExQuery(qry1);
                    conn.ExQuery(qry2);

                    textBox3.Text = "";
                    textBox4.Text = "";

                    MessageBox.Show("Entry Added");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Check database connection");
                }
            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String loc = (String)comboBox2.SelectedItem;
            textBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll3 = new AutoCompleteStringCollection();

            string qry = "Select * from inventory_fd where location='" + loc + "';";

            MySqlConnection connst = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd1 = new MySqlCommand(qry, connst);
            MySqlDataReader reader;

            try
            {
                connst.Open();
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {

                    string iname = reader.GetString("productID");
                    coll3.Add(iname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "database error");
            }

            textBox3.AutoCompleteCustomSource = coll3;
            connst.Close();

            connst.Open();
            String qry3 = "SELECT * from fd_trans where location='" + loc + "' and type='Issue' ";
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
    }
}
