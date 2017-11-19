using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
>>>>>>> c6538202052fcdf8a6f23292e83b227b8cdf31a7
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
<<<<<<< HEAD
    public partial class ProductItems : UserControl
    {
        private static ProductItems _instance;

        public static ProductItems Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new ProductItems();
                return _instance;

            }
        } 
        public ProductItems()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProductItems_Load(object sender, EventArgs e)
        {
            
        }
    }
}
=======
    public partial class ProductItems : Form
    {
        DBAccess db = new DBAccess();
        public ProductItems()
        {
            InitializeComponent();
            fillcombo();
            
        }

        void fillcombo()
        {
            
            try {
                String query = "Select * from inventory";
                db.Open();
                MySqlCommand cmd = new MySqlCommand(query);
                MySqlDataReader myR;

                myR = cmd.ExecuteReader();

                while (myR.Read())
                {
                    string name = myR.GetString("name");
                    cmbItemName.Items.Add(name);
                }
            }
            catch { }
            

        }
        String pid { get; set; }
       
        public ProductItems(String ppid)
        {
            this.pid = ppid;
        }

        private void ProductItems_Load(object sender, EventArgs e)
        {
            txtPid.Text = AddProduct.ppid;

            try
            {
                gvUser.AutoGenerateColumns = false;
                string sql = "SELECT item_id,name FROM inventory";
                DataTable dt = db.Select(sql);
                gvUser.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            ProductService ps=new ProductService();
           ps.SelectProduct(txtItemName.Text);
            ProductItem pi = new ProductItem();
            txtItemId.Text = ProductItem.ItemId;
        }

        private void gvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    string selectedUserId = gvUser.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    ProductItem prod = new ProductItem();
                    //prod.ItemId 
                    //frmUsr.Show();
                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbItemName_TextChanged(object sender, EventArgs e)
        {
            
                        //String query = "SELECT name FROM inventory ";
                        //DataTable dt = new DataTable();
                        //dt = db.Select(query);
                        //using (String command = new MySqlCommand(query, connection))
                        //{
                        //    using (var reader = command.ExecuteReader())
                        //    {
                        //        //Iterate through the rows and add it to the combobox's items
                        //        while (reader.Read())
                        //        {
                        //            CustomerIdComboBox.Items.Add(reader.GetString("Id"));    
                        //        }
                        //    }    
                        //}
         }

        }
    }

>>>>>>> c6538202052fcdf8a6f23292e83b227b8cdf31a7
