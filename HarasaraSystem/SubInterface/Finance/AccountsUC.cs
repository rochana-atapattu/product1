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
    public partial class AccountsUC : UserControl
    {
        private static AccountsUC _instance_auc;
        public static AccountsUC Instance_auc
        {
            get
            {
                if (_instance_auc == null)
                {
                    _instance_auc = new AccountsUC();
                }
                return _instance_auc;
            }
        }
        public AccountsUC()
        {
            InitializeComponent();
        }

        private void AccountsUC_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(AccountHistoryUC_a.Instance_ah_a))
            {
                panel1.Controls.Add(AccountHistoryUC_a.Instance_ah_a);
                AccountHistoryUC_a.Instance_ah_a.Dock = DockStyle.Fill;
                AccountHistoryUC_a.Instance_ah_a.BringToFront();
            }
            else
            {
                AccountHistoryUC_a.Instance_ah_a.BringToFront();
                //AccountHistoryUC_a.Instance_ah_a.Visible = true;
                AccountHistory.Instance_ah.Visible = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ProfitLossUC_Main.Instance_pf_main))
            {
                panel1.Controls.Add(ProfitLossUC_Main.Instance_pf_main);
                ProfitLossUC_Main.Instance_pf_main.Dock = DockStyle.Fill;
                ProfitLossUC_Main.Instance_pf_main.BringToFront();
            }
            else
            {
                ProfitLossUC_Main.Instance_pf_main.BringToFront();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(PettyCashUC.Instance_pc))
            {
                panel1.Controls.Add(PettyCashUC.Instance_pc);
                PettyCashUC.Instance_pc.Dock = DockStyle.Fill;
                PettyCashUC.Instance_pc.BringToFront();
            }
            else
            {
                PettyCashUC.Instance_pc.BringToFront();
                PettyCashUC_Add.Instance_pca.Visible = false;
                PettyCashUC_Add_Summary.Instance_pc_as.Visible = false;
                PettyCashUC_Add_Edit._Instance_pc_add.Visible = false;
                PettyCashUC.Instance_pc.Visible = true;
            }
        }
    }
}
