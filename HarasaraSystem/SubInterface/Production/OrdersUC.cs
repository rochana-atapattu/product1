using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
    public partial class OrdersUC : UserControl
    {
        private static OrdersUC _instance;

        public static OrdersUC Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new OrdersUC();
                return _instance;

            }
        }
        DBAccess db=new DBAccess();
        prepareOrder pre = new prepareOrder();
        public OrdersUC()
        {
            InitializeComponent();
            FillDGV();

        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            FillDGVpen();
        }
        public void FillDGVpen()
        {
            String status = "pending";
            String query = "SELECT * FROM products where status = '" + status + "'";

            try
            {
                DataTable dt = new DataTable();
                dt = db.Select(query);


                dataGridView1.DataSource = dt;
                dataGridView1.Columns["productPrice"].Visible = false;
                dataGridView1.Columns["totalPrice"].Visible = false;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            String pid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String qty = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            String oid = dataGridView1.CurrentRow.Cells[6].Value.ToString();


            
            pre.checkAvailability();

           
        }

        private void bunifuThinButton3_Click(object sender, EventArgs e)
        {
            String oid = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            String pid = dataGridView1.CurrentRow.Cells[0].Value.ToString();


            splitOrder s = new splitOrder(oid,pid);
            s.split();
        }
        public void FillDGV()
        {
            
            String query = "SELECT * FROM products ";

            try
            {
                DataTable dt = new DataTable();
                dt = db.Select(query);


                dataGridView1.DataSource = dt;
                dataGridView1.Columns["productPrice"].Visible = false;
                dataGridView1.Columns["totalPrice"].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void OrdersUC_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
