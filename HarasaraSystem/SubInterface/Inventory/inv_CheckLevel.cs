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
    public partial class inv_CheckLevel : UserControl
    {
        

        private static inv_CheckLevel _instance;

        public static inv_CheckLevel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new inv_CheckLevel();
                return _instance;
            }
        }
        public inv_CheckLevel()
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
            /*dbconnect dbcon=new dbconnect();
            String qry = "Select * From warehouse";
            String Keyi="location";
            String[] arr = new String[10];
            arr=dbcon.GetValues(qry,Keyi);
            int i = 0;
            while(arr.Length<10){
                comboBox1.Items.Add(arr[i]);
                comboBox2.Items.Add(arr[i]);
                i++;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbconnect dbcon = new dbconnect();

            String loc = (String)comboBox1.SelectedItem;
            String qry3 = "SELECT * from inventory where location='" + loc + "' ";
            
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dbcon.ReadValue(qry3);

            dataGridView1.DataSource = bsource;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void inv_CheckLevel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {            
            dbconnect dbcon = new dbconnect();

            String loc = (String)comboBox2.SelectedItem;
            String qry3 = "SELECT * from inventory_fd where location='" + loc + "' ";

            BindingSource bsource = new BindingSource();

            bsource.DataSource = dbcon.ReadValue(qry3);

            dataGridView2.DataSource = bsource;
        }
    }
}
