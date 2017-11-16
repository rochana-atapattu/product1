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
    public partial class ProfitLossUC_Main : UserControl
    {
        private static ProfitLossUC_Main _instance_pf_main;
        public static ProfitLossUC_Main Instance_pf_main
        {
            get
            {
                if (_instance_pf_main == null)
                {
                    _instance_pf_main = new ProfitLossUC_Main();
                }
                return _instance_pf_main;
            }
        }
        public ProfitLossUC_Main()
        {
            InitializeComponent();
        }

        private void ProfitLossUC_Main_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadChart()
        {
            try
            {
                chart1.Series.Clear();
                this.chart1.Series.Add("profit");
                this.chart1.Series.Add("loss");
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
                string query = "SELECT Date,Profit,Loss FROM profit_loss WHERE date <='" + this.dateTimePicker2.Text + "' AND date>='" + this.dateTimePicker1.Text + "'";
                MySqlCommand cmnd = new MySqlCommand(query, con);
                MySqlDataReader myreader;
                con.Open();
                myreader = cmnd.ExecuteReader();
                while (myreader.Read())
                {
                    //string inc = myreader.GetString(0);
                    this.chart1.Series["profit"].Points.AddXY(myreader.GetString("date"), myreader.GetDouble("profit"));
                    this.chart1.Series["loss"].Points.AddXY(myreader.GetString("date"), myreader.GetDouble("loss"));

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
