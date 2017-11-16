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
    public partial class ExpenditureManagerUC : UserControl
    {
        private static ExpenditureManagerUC _instance;
        public static ExpenditureManagerUC Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ExpenditureManagerUC();
                }
                return _instance;
            }
        }
        public ExpenditureManagerUC()
        {
            InitializeComponent();
            LoadLabels();
            LoadExpenditure();
            LoadBalance();
            LoadPercentage();
            LoadExpenditureIncomeChart();
        }

        private void ExpenditureManagerUC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        public void LoadLabels()
        {
            //string date=trunc
            try
            {
                DateTime dt = DateTime.Now;
                string dat = dt.ToString("yyyy-MM-dd");
                string query = "SELECT profit,date FROM profit_loss WHERE date='" + dat + "'";
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                MySqlCommand cmnd = new MySqlCommand(query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmnd.ExecuteReader();
                while (myReader.Read())
                {
                    string inc = myReader.GetString("profit");
                    string pdate = myReader.GetString("date");
                    bunifuCustomLabel5.Text = inc;
                    bunifuCustomLabel6.Text = dat;
                    bunifuCustomLabel7.Text = dat;
                    bunifuCustomLabel10.Text = dat;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadExpenditure()
        {
            try
            {
                DateTime dt = DateTime.Now;
                string dat = dt.ToString("yyyy-MM-dd");
                string query = "SELECT SUM(Salary)+SUM(Utility)+SUM(Rent) FROM pettycash WHERE date='" + dat + "'";
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                MySqlCommand cmnd = new MySqlCommand(query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmnd.ExecuteReader();
                while (myReader.Read())
                {
                    string bal = myReader.GetString(0);
                    bunifuCustomLabel8.Text = bal;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadBalance()
        {
            try
            {
                DateTime dt = DateTime.Now;
                string dat = dt.ToString("yyyy-MM-dd");
                string query = "SELECT BALANCE FROM account WHERE accountnumber=123456789112456";
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                MySqlCommand cmnd = new MySqlCommand(query, con);
                MySqlDataReader myReader;
                con.Open();
                myReader = cmnd.ExecuteReader();
                while (myReader.Read())
                {
                    string bal = myReader.GetString(0);
                    bunifuCustomLabel11.Text = bal;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadPercentage()
        {
            double income = Convert.ToDouble(bunifuCustomLabel5.Text);
            double expenditure = Convert.ToDouble(bunifuCustomLabel8.Text);
            double pProfit = ((income - expenditure) / expenditure) * 100;
            int p_profit = Convert.ToInt32(pProfit);
            bunifuCustomLabel14.Text = Convert.ToString(p_profit) + "%";

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadExpenditureIncomeChart()
        {
            try
            {
                DateTime dt = DateTime.Now;
                string dat = dt.ToString("yyyy-MM-dd");
                chart1.Series.Clear();
                this.chart1.Series.Add("Income");
                this.chart1.Series.Add("Expenditure");
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                string query = "SELECT Date,Income,SUM(Salary)+SUM(Utility)+SUM(Rent) FROM pettycash WHERE date='" + dat + "'";
                MySqlCommand cmnd = new MySqlCommand(query, con);
                MySqlDataReader myreader;
                con.Open();
                myreader = cmnd.ExecuteReader();
                while (myreader.Read())
                {
                    //string inc = myreader.GetString(0);
                    this.chart1.Series["Income"].Points.AddXY(myreader.GetString("date"), myreader.GetString("income"));
                    this.chart1.Series["Expenditure"].Points.AddXY(myreader.GetString("date"), myreader.GetString(2));

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
