using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Inventory

{
    public partial class InventorySub : Form
    {
        public InventorySub(string pt)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if(!panel3.Controls.Contains(BMS_harasara.inv_AddStock.Instance))
            {
                panel3.Controls.Add(BMS_harasara.inv_AddStock.Instance);
                BMS_harasara.inv_AddStock.Instance.Dock = DockStyle.Fill;
                BMS_harasara.inv_AddStock.Instance.BringToFront();
            }
            else
            {
                BMS_harasara.inv_AddStock.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(BMS_harasara.inv_IssueStock.Instance))
            {
                panel3.Controls.Add(BMS_harasara.inv_IssueStock.Instance);
                BMS_harasara.inv_IssueStock.Instance.Dock = DockStyle.Fill;
                BMS_harasara.inv_IssueStock.Instance.BringToFront();
            }
            else
            {
                BMS_harasara.inv_IssueStock.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(BMS_harasara.inv_CheckLevel.Instance))
            {
                panel3.Controls.Add(BMS_harasara.inv_CheckLevel.Instance);
                BMS_harasara.inv_CheckLevel.Instance.Dock = DockStyle.Fill;
                BMS_harasara.inv_CheckLevel.Instance.BringToFront();
            }
            else
            {
                BMS_harasara.inv_CheckLevel.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(BMS_harasara.inv_FinishStock.Instance))
            {
                panel3.Controls.Add(BMS_harasara.inv_FinishStock.Instance);
                BMS_harasara.inv_FinishStock.Instance.Dock = DockStyle.Fill;
                BMS_harasara.inv_FinishStock.Instance.BringToFront();
            }
            else
            {
                BMS_harasara.inv_FinishStock.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(AddItem.Instance))
            {
                panel3.Controls.Add(AddItem.Instance);
                AddItem.Instance.Dock = DockStyle.Fill;
                AddItem.Instance.BringToFront();
            }
            else
            {
                AddItem.Instance.BringToFront();
            }
        }
    }
}
