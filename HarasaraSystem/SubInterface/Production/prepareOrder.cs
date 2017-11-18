using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
    class prepareOrder
    {
        DBAccess db = new DBAccess();
        public void checkAvailability()
        {
            String query = "SELECT * FROM inventory";

            DataTable dt = new DataTable();
            dt = db.Select(query);


            var rowColl = dt.AsEnumerable();
            int count = (from r in rowColl
                           where r.Field<int>("item_id") == 2
                           select r.Field<int>("count")).First<int>();

            MessageBox.Show("count is " + count);
        }
        
        
    }
}
