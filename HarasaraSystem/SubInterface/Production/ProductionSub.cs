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
    public partial class ProductionSub : Form
    {

        DBAccess dbaccess = new DBAccess();
        public ProductionSub(string pt)
        {
            InitializeComponent();
            label4.Text = pt;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void SalesSub_Load(object sender, EventArgs e)
        {
            timer1.Start();

            try
            {
                gvUser.AutoGenerateColumns = false;
                string sql = "SELECT ProductId,ProductName,UnitPrice,EstimatedDays,ProductCategory,ProductImage FROM Product";
                DataTable dt = dbaccess.Select(sql);
                gvUser.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
           ap.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();
        }
    }
}
