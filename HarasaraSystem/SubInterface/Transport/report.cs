using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS_harasara;

namespace Transport
{
    public partial class report : Form
    {
       
        public report(string user)
        {
            InitializeComponent();
            timer1.Start();
            label7.Text = user;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main(label7.Text);
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main("");
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main(label7.Text);
            m1.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton3_Click(object sender, EventArgs e)
        {
            HarasaraSystem.MainMenu mm = new HarasaraSystem.MainMenu();
            this.Hide();
            mm.Show();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            


        }

        private void report_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 10, 10);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if ((string)comboBox1.SelectedItem == "Vehicle repair")
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();

                dt = db.ReadValue("Select * From vehiclerepair where SubmittedDate between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'");
                dataGridView1.DataSource = dt;
            }
            else if ((string)comboBox1.SelectedItem == "Driver details")
            {
                DataTable dt = new DataTable();
                dbconnect db = new dbconnect();

                dt = db.ReadValue("Select * From driverdetails where DOB between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'");
                dataGridView1.DataSource = dt;
            }  
        }
    }
}
