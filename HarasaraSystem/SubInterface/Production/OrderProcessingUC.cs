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
    public partial class OrderProcessingUC : UserControl
    {
        private static OrderProcessingUC _instance;

        public static OrderProcessingUC Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new OrderProcessingUC();
                return _instance;

            }
        }
        public OrderProcessingUC()
        {
            InitializeComponent();
        }
        DBAccess db = new DBAccess();
        private String pid;


        private void OrderProcessingUC_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pid= this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            FillDGV();
            
        }
        void fillcombo()
        {
            String query = "SELECT DISTINCT productID FROM splittedOrder";

            DataTable dt = new DataTable();
            dt = db.Select(query);

            

            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                comboBox1.Items.Add(dt.Rows[i]["productID"].ToString());
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void FillDGV()
        {

            String query = "SELECT * FROM splittedOrder WHERE productID= '" + pid + "' ";

            try
            {
                DataTable dt = new DataTable();
                dt = db.Select(query);


                dataGridView1.DataSource = dt;
                dataGridView1.Columns["cutting"].Visible = false;
                dataGridView1.Columns["painting"].Visible = false;
                dataGridView1.Columns["fitting"].Visible = false;
                dataGridView1.Columns["drilling"].Visible = false;
                dataGridView1.Columns["finishing"].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
