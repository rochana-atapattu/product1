using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HarasaraSystem.SubInterface.Sales;
using System.Data;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Administration
{
    class DBconnect
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=harasara");
        MySqlCommand cmd;




        public void InsertDeleteUpdate(string query)
        {
            con.Open();

            try
            {

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                CustomMsgBox.Show("Process Successfull", "OK");

            }
            catch (Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");

            }

            con.Close();
        }

        public void tableLoad(string query, DataGridView dw)
        {
            con.Open();
            try
            {


                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();


                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dw.DataSource = dt;

            }
            catch (Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");

            }
            con.Close();
        }

        public String getValue(String qw)
        {
            String txt;

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            MySqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = qw;

                object p = cmd.ExecuteScalar();
                txt = p.ToString();
                con.Close();

                return txt;
            }
            catch (Exception e1)
            {
                con.Close();
                return "";
            }
        }

    }
}
