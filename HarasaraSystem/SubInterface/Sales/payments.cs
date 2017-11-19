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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void payments_Load(object sender, EventArgs e)
        {
            databaseAccess d1 = new databaseAccess();


            string query = "select *  from harasara.payments";

            d1.displayData(query, dataGridView1);
        }
    }
}
