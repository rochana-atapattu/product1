using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Administration

{
    public partial class AdministrationSub : Form
    {
        public AdministrationSub(string pt)
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

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
       
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(SystemAdmins.Instance))
            {
                panel3.Controls.Add(SystemAdmins.Instance);
                SystemAdmins.Instance.Dock = DockStyle.Fill;
                SystemAdmins.Instance.BringToFront();
            }

            else
                SystemAdmins.Instance.BringToFront(); 
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
             if (!panel3.Controls.Contains(Machines.Instance))
            {
                panel3.Controls.Add(Machines.Instance);
                Machines.Instance.Dock = DockStyle.Fill;
                Machines.Instance.BringToFront();
            }

            else
                Machines.Instance.BringToFront(); 
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(promo.Instance))
            {
                panel3.Controls.Add(promo.Instance);
                promo.Instance.Dock = DockStyle.Fill;
                promo.Instance.BringToFront();
            }

            else
                promo.Instance.BringToFront(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        }
=======
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
>>>>>>> 184c2815955e13adcce79d75275bec5fa1887f3c
    }

