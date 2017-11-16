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

namespace HarasaraSystem.SubInterface.Finance
{
    public partial class PettyCashUC_Add_Edit : UserControl
    {
        private static PettyCashUC_Add_Edit _instance_pc_add;
        public static PettyCashUC_Add_Edit _Instance_pc_add
        {
            get
            {
                if (_instance_pc_add == null)
                {
                    _instance_pc_add = new PettyCashUC_Add_Edit();
                }
                return _instance_pc_add;
            }
        }
        public PettyCashUC_Add_Edit()
        {
            InitializeComponent();
            LoadLabelValues();
        }
        public void EnterAllTextBoxValues(string qu, string type)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmnd = new MySqlCommand(qu, con);
            MySqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmnd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(type);
                    //bunifuCustomTextbox7.Text = sname;
                    if (string.Compare(type, "Sales") == 0)
                    {
                        bunifuCustomTextbox7.Text = sname;
                    }
                    else if (string.Compare(type, "Salary") == 0)
                    {
                        bunifuCustomTextbox2.Text = sname;
                    }
                    else if (string.Compare(type, "Voucher") == 0)
                    {
                        bunifuCustomTextbox1.Text = sname;
                    }
                    else if (string.Compare(type, "Utility") == 0)
                    {
                        bunifuCustomTextbox3.Text = sname;
                    }
                    else if (string.Compare(type, "Rent") == 0)
                    {
                        bunifuCustomTextbox4.Text = sname;
                    }
                    else if (string.Compare(type, "Income") == 0)
                    {
                        bunifuCustomTextbox5.Text = sname;
                    }
                    else if (string.Compare(type, "Other") == 0)
                    {
                        bunifuCustomTextbox6.Text = sname;
                    }
                    else if (string.Compare(type, "Capital") == 0)
                    {
                        bunifuCustomTextbox8.Text = sname;
                    }
                    else
                    {
                        MessageBox.Show("Invalid");
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadLabelValues()
        {
            string query = "SELECT Balance FROM account WHERE accountnumber=123456789112456";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmnd = new MySqlCommand(query, con);
            MySqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmnd.ExecuteReader();
                while (myreader.Read())
                {
                    string bal = myreader.GetString("Balance");
                    label2.Text = bal;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            PettyCashUC_Add_Edit._Instance_pc_add.Visible = false;
            PettyCashUC_Add.Instance_pca.BringToFront();
            PettyCashUC_Add.Instance_pca.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string query = "SELECT Sales FROM pettycash WHERE date='" + this.dateTimePicker1.Text + "'";
            string query1 = "SELECT Salary FROM pettycash WHERE date='" + this.dateTimePicker1.Text + "'";
            string query2 = "SELECT Voucher FROM pettycash WHERE date='" + this.dateTimePicker1.Text + "'";
            string query3 = "SELECT Rent FROM pettycash WHERE date='" + this.dateTimePicker1.Text + "'";
            string query4 = "SELECT Other FROM pettycash WHERE date='" + this.dateTimePicker1.Text + "'";
            string query5 = "SELECT Income FROM pettycash WHERE date='" + this.dateTimePicker1.Text + "'";
            string query6 = "SELECT Utility FROM pettycash WHERE date='" + this.dateTimePicker1.Text + "'";
            string query7 = "SELECT Capital FROM pettycash WHERE date='" + this.dateTimePicker1.Text + "'";

            EnterAllTextBoxValues(query, "Sales");
            EnterAllTextBoxValues(query1, "Salary");
            EnterAllTextBoxValues(query2, "Voucher");
            EnterAllTextBoxValues(query3, "Rent");
            EnterAllTextBoxValues(query4, "Other");
            EnterAllTextBoxValues(query5, "Income");
            EnterAllTextBoxValues(query6, "Utility");
            EnterAllTextBoxValues(query7, "Capital");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuCustomTextbox1.Text))
            {
                MessageBox.Show("Enter Voucher Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox2.Text))
            {
                MessageBox.Show("Enter Voucher Salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox3.Text))
            {
                MessageBox.Show("Enter Utility.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox4.Text))
            {
                MessageBox.Show("Enter Rent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox5.Text))
            {
                MessageBox.Show("Enter Income.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox6.Text))
            {
                MessageBox.Show("Enter Other.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox7.Text))
            {
                MessageBox.Show("Enter Sales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(bunifuCustomTextbox8.Text))
            {
                MessageBox.Show("Enter Capital.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    string query = "UPDATE pettycash SET sales='" + Convert.ToDouble(bunifuCustomTextbox7.Text) + "',Salary='" + Convert.ToDouble(bunifuCustomTextbox2.Text) + "',Rent='" + Convert.ToDouble(bunifuCustomTextbox4.Text) + "',Other='" + Convert.ToDouble(bunifuCustomTextbox6.Text) + "',Income='" + Convert.ToDouble(bunifuCustomTextbox5.Text) + "',Utility='" + Convert.ToDouble(bunifuCustomTextbox3.Text) + "',Capital='" + Convert.ToDouble(bunifuCustomTextbox8.Text) + "' WHERE Voucher='" + Convert.ToInt32(bunifuCustomTextbox1.Text) + "'";
                    MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                    MySqlCommand cmnd = new MySqlCommand(query, con);
                    MySqlDataReader myReader;
                    con.Open();
                    myReader = cmnd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Updated Sucessfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
