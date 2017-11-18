using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarasaraSystem.SubInterface.Production
{
    class Finishing : Manufacturing
    {
        private String pid;
        private String oid;
        private int queNum;
        Boolean progress = true;
        public Finishing(String pid,String oid,int queNum)
        {
            this.pid = pid;
            this.oid = oid;
            this.queNum = queNum;

        }
        public void updateProgress()
        {

            DBAccess db = new DBAccess();

            db.Update("UPDATE `splittedorder` SET `finishing`= '" + progress + "' WHERE `productID`= '" + pid + "',`orderID`= '" + oid + "',`queNo`= '" + queNum + "',");
        }
    }
}
