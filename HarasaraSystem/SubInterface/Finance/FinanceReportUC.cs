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
    public partial class FinanceReportUC : UserControl
    {
        private static FinanceReportUC _instance_fr;
        public static FinanceReportUC Instance_fr
        {
            get
            {
                if(_instance_fr==null)
                {
                    _instance_fr = new FinanceReportUC();
                }
                return _instance_fr;
            }
        }
        public FinanceReportUC()
        {
            InitializeComponent();
            CrystalReport1 a1 = new CrystalReport1();
            crystalReportViewer1.ReportSource = a1;
        }

        private void FinanceReportUC_Load(object sender, EventArgs e)
        {

        }
    }
}
