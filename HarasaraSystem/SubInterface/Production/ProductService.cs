using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace HarasaraSystem.SubInterface.Production
{
    class ProductService
    {

        public ProductItem SelectProduct(string ItemName)
        {
            ProductItem ProItem = new ProductItem();
            try
            {
                string sql = "SELECT item_id FROM inventory where name LIKE '" + ItemName + "'%";
                DBAccess db = new DBAccess();
                DataTable dt = db.Select(sql);
                foreach (DataRow row in dt.Rows)
                {
                    ProItem.ItemId = Convert.ToInt32(row["ItemId"]);
                 }
            }
            catch (Exception)
            {

                throw;
            }
            return ProItem;
        }
    }
}
