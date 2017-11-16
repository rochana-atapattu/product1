using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Finance
{
    public partial class AccountHistory : UserControl
    {
        private static AccountHistory _instance_ah;
        public static AccountHistory Instance_ah
        {
            get
            {
                if (_instance_ah == null)
                {
                    _instance_ah = new AccountHistory();
                }
                return _instance_ah;
            }
        }
        public AccountHistory()
        {
            InitializeComponent();
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM products");
            dataGridView1.DataSource = ds.Tables["load"];
        }

        private void AccountHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
