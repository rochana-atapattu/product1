using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarasaraSystem.SubInterface.Sales
{
    public partial class Bill : Form
    {
        string pType="xx";
       string cType=" ";
        public Bill(string cusName, string conNumber, string address, string Email, string OrID,string finalPrice)
        {
            InitializeComponent();
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            textBox1.Enabled = false;

            cusBill.Text = cusName;
            conNumberBill.Text = conNumber;
            addBill.Text = address;
            emailBill.Text = Email;
            invoiceBill.Text = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString();
            label2.Text = OrID;
            label1.Text = finalPrice;
            

            string query = "select * from harasara.products where orderID='"+OrID+"'";
            databaseAccess db1=new databaseAccess();
            db1.displayData(query, BillProducts);

           // string query1= "select price from harasara.slorders where orderID='" + OrID + "' ";

           

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PayB_Click(object sender, EventArgs e)
        {
            databaseAccess d1 = new databaseAccess();
            string pID = "SL" + invoiceBill.Text+label2.Text;
            string Card="Cash";
            if (pType =="Cash")
            {
                string query = "insert into harasara.payments(PaymentID,date,type,CardNumber,orderID,Price) values('" + pID + "','" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "','" + pType + "','"+Card+"','" + label2.Text + "','" + Convert.ToDouble(label1.Text) + "') ";
                d1.InsertData(query);

            }
            else if (pType == "Credit")
            {
               
                string query = "insert into harasara.payments(PaymentID,date,type,CardNumber,orderID,Price) values('" + pID + "','" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "','" + pType + "','" + textBox1.Text + "','" + label2.Text + "','" + Convert.ToDouble(label1.Text) + "') ";
                d1.InsertData(query);

            }

            string dlQuery="Delete from harasara.slorders where orderID='" + label2.Text + "'";
            d1.deleterow(dlQuery);
            CustomMsgBox.Show("Payment was successfull","OK");
           
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            //YearandMonth.Text = DateTime.Now.Year.ToString()+DateTime.Now.Month.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pType = "Cash";
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            textBox1.Enabled = false;
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pType = "Credit";
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            textBox1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           cType = "Visa";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            cType = "MasterCard";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validation v = new validation();
            v.creditCardValidations(textBox1.Text, label6);
        }

       
    }
}
