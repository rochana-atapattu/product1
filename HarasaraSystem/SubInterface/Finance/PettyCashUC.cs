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
    public partial class PettyCashUC : UserControl
    {
        private static PettyCashUC _instance_pc;
        public static PettyCashUC Instance_pc
        {
            get
            {
                if (_instance_pc == null)
                {
                    _instance_pc = new PettyCashUC();
                }
                return _instance_pc;
            }
        }
        public PettyCashUC()
        {
            InitializeComponent();
            Database db = new Database();
            DataSet ds = db.dbse("SELECT * FROM pettycash");
            dataGridView1.DataSource = ds.Tables["load"];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(PettyCashUC_Add.Instance_pca))
            {
                panel1.Controls.Add(PettyCashUC_Add.Instance_pca);
                PettyCashUC_Add.Instance_pca.Dock = DockStyle.Fill;
                PettyCashUC_Add.Instance_pca.BringToFront();
            }
            else
            {
                PettyCashUC_Add.Instance_pca.BringToFront();
                PettyCashUC_Add.Instance_pca.Visible = true;
            }
        }
    }
}
