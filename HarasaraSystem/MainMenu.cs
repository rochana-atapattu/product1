using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubInterface.Transport.TansportSub trafrm = new SubInterface.Transport.TansportSub();
            trafrm.Show();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            Login l1 = new Login("Employees");
            l1.Show();
            this.Hide();

        }

        private void Leave_Click(object sender, EventArgs e)
        {
            Login l1 = new Login("Finance");
            l1.Show();
            this.Hide();
        }

        private void Request_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Login l1 = new Login("Inventory");
            l1.Show();
            this.Hide();
        }

        private void Transport_Click(object sender, EventArgs e)
        {
            Login l1 = new Login("Transport");
            l1.Show();
            this.Hide();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Login l1 = new Login("Sales Manager");
            l1.Show();
            this.Hide();
        }

        private void Production_Click(object sender, EventArgs e)
        {
            Login l1 = new Login("Products");
            l1.Show();
            this.Hide();
        }

        private void SystemAdministration_Click(object sender, EventArgs e)
        {
            Login l1 = new Login("Adminstration");
            l1.Show();
            this.Hide();
        }
    }
}
