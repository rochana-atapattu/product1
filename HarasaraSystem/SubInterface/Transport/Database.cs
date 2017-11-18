using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace BMS_harasara
{
    class Database
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasaraindustries");
        public DataSet dbse(string qu)
        {
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }
            try
            {
                MySqlCommand cmdg = con.CreateCommand();
                cmdg.Connection = con;
                cmdg.CommandType = CommandType.Text;
                cmdg.CommandText = qu;

                MySqlDataAdapter data = new MySqlDataAdapter(cmdg);
                DataSet ds = new DataSet();
                data.Fill(ds, "load");
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong please check your database connection");
                DataSet ee = new DataSet();
                return ee;
            }
        }
    }

}
