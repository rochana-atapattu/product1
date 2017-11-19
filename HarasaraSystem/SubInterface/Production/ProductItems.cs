using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
    public partial class ProductItems : Form
    {
        DBAccess db = new DBAccess();
        public ProductItems()
        {
            InitializeComponent();
            
        }
        String pid { get; set; }
       
        public ProductItems(String ppid)
        {
            this.pid = ppid;
        }

        private void ProductItems_Load(object sender, EventArgs e)
        {
            txtPid.Text = AddProduct.ppid;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String itemname = txtItemName.Text;

           // String sql = "SELECT item_id FROM inventory WHERE name LIKE '" + itemname+"'%";
            ProductService ps = new ProductService();
            txtItemId.Text = ps.SelectProduct(itemname).ToString();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
