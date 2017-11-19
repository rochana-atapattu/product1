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
    public partial class payments : UserControl
    {
        private static payments _instance;

        public static payments Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new payments();
                return _instance;
                
            }
        }
        public payments()
        {
            InitializeComponent();

            //string query = "select customerName from harasara.customer";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

<<<<<<< HEAD
            databaseAccess d1 = new databaseAccess();
            string query1 = "select * from payments";
            string query2 = "select * from customer";
            string query3 = "select * from supplier";
            string query4 = "select * from purchasepayments";
            d1.displayData(query1, dataGridView1);
            d1.displayData(query4, dataGridView2);
            d1.ComboBoxLoad("customerName", comboBox1, query2);
            d1.ComboBoxLoad("supplierName", comboBox4, query3);

            
=======
>>>>>>> c6538202052fcdf8a6f23292e83b227b8cdf31a7
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            databaseAccess d1=new databaseAccess();
            
            string query = "select contactNumber from supplier where supplierName='"+comboBox4.Text+"'";
            textBox4.Text = d1.getString(query);
            string query2 = "select SupID  from supplier where supplierName='"+comboBox4.Text+"'";

            string supID = d1.getString(query2);
            string query3 = "select * from  purchasepayments where SupplierID='"+supID+"'";
            d1.displayData(query3, dataGridView2);
        }
=======
        private void payments_Load(object sender, EventArgs e)
        {
            databaseAccess d1 = new databaseAccess();
>>>>>>> c6538202052fcdf8a6f23292e83b227b8cdf31a7


            string query = "select *  from harasara.payments";

            d1.displayData(query, dataGridView1);
        }
    }
}
