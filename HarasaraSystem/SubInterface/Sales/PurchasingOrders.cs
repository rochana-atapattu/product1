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

namespace HarasaraSystem.SubInterface.Sales
{
    public partial class PurchasingOrders : UserControl
 {

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root");
        MySqlCommand cmd;

        private static PurchasingOrders _instance;

        public static PurchasingOrders Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new PurchasingOrders();
                return _instance;

            }
        }
        public PurchasingOrders()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void PurchasingOrders_Load(object sender, EventArgs e)
        {
            string query = "select item_id,name,type,price from harasara.inventory where count=rol";
            databaseAccess d1 = new databaseAccess();
            d1.displayData(query, dataGridView1);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = dataGridView1.SelectedRows[0].Index;

            int ItemID = Convert.ToInt32(dataGridView1.Rows[Index].Cells[0].Value);

            string query = "select distinct(SupID) from harasara.itemsandsupplier where ItemNo='" + ItemID + "'";
            databaseAccess d1 = new databaseAccess();
            d1.ComboBoxLoad("SupID", comboBox1, query);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select distinct supplierName from harasara.supplier where SupID='" + comboBox1.Text + "'";

            databaseAccess d1 = new databaseAccess();
            label4.Text=  d1.getString(query);
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation v1 = new validation();

            char tt = e.KeyChar;

            v1.validatedigitCharacters(tt, error);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(quantity.Text) )
            {
                error.ForeColor = Color.Red;
                error.Text = "Please,Input Qunantity";
            }
            else if(String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                error.ForeColor = Color.Red;
                error.Text = "Select Supplier";
            }
            else
            {
                databaseAccess d1 = new databaseAccess();
                int qu = Convert.ToInt32(quantity.Text);
                int Index = dataGridView1.SelectedRows[0].Index;
                int itemID = Convert.ToInt32(dataGridView1.Rows[Index].Cells[0].Value);
                string desc = dataGridView1.Rows[Index].Cells[1].Value.ToString();
                double price = Convert.ToDouble(dataGridView1.Rows[Index].Cells[3].Value);

                double tPrice = qu*price;
                
                string query = "insert into harasara.ordereditems (ItemNo,ItemDescription,Price,Quantity,TotalPrice,SupplierId,Date)values ('"+itemID+"','"+desc+"','"+price+"','"+qu+"','"+tPrice+"','"+comboBox1.Text+"','"+dateTimePicker1.Text+"')";
                d1.InsertData(query);
                d1.deleteSelectedRow(dataGridView1);
                string query1 = "select * from harasara.ordereditems where Date='"+dateTimePicker1.Text+"'";
                d1.displayData(query1,dataGridView2);



               



            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            databaseAccess d1=new databaseAccess();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            string query = "select SupplierId,sum(TotalPrice) from harasara.ordereditems where Date='" + dateTimePicker1.Text + "'  group by SupplierId";

            cmd.CommandText = query;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            foreach(DataRow dr in dt.Rows)
            {
                string id = dr[0].ToString();
                double ppp = Convert.ToDouble(dr[1]);

                string query1 = "insert into harasara.purchaseorders (SupplierId,Price,Date) values ('"+id+"','"+ppp+"','"+dateTimePicker1.Text+"')";
                d1.InsertData(query1);
            }

            string query2 = "select * from harasara.purchaseorders";

            d1.displayData(query2, dataGridView3);

        }

        private void Pay_Click(object sender, EventArgs e)
        {
          
        }

       
                                   
                                   


        }
    
}
