﻿using System;
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

        private void employees_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("HR Manager");
            m1.Show();
            this.Hide();
        }

        private void Transport_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("Transport");
            m1.Show();
<<<<<<< HEAD
=======
            this.Hide();*/
            Login ins = new Login("Transport");
            ins.Show();
>>>>>>> 184c2815955e13adcce79d75275bec5fa1887f3c
            this.Hide();
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            SubInterface.Employee.leaverequest load = new SubInterface.Employee.leaverequest();
            load.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("Sales Manager");
            m1.Show();
            this.Hide();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("Inventory");
            m1.Show();
            this.Hide();
        }

        private void Finance_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("Finance");
            m1.Show();
            this.Hide();
        }

        private void production_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("Products");
            m1.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Login m1 = new Login("Adminstration");
            m1.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SubInterface.Employee.AttendanceSystem load = new SubInterface.Employee.AttendanceSystem();
            load.Show();
            this.Hide();
      
        }
       

       

        
        

        
    }
}
