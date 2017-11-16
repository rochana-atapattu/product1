using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Transport
{
    public class dbconnect
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=harasara");

        public void openconn()
        {
            conn.Open();
        }

        public void closeconn()
        {
            conn.Close();
        }

        public DataTable ReadValue(string qry)
        {
            string x = qry;
            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(x, conn);

            da.Fill(dt);

            return dt;
        }
    }
}

