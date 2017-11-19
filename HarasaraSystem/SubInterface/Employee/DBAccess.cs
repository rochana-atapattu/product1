using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//using System.Windows.Forms;
using System.Data;

namespace HarasaraSystem.SubInterface.Employee
{
    class DBAccess
    {
        
        
            MySqlConnection con=new MySqlConnection("server=localhost;user id=root;database=harasara");
            MySqlCommand cmd;

            public void insertData(string query)
            {
                con.Open();


                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();


                con.Close();

            }

      



           
        
    }
}
