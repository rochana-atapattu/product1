using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Production
{
    public partial class ProductItems : UserControl
    {
        private static ProductItems _instance;

        public static ProductItems Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new ProductItems();
                return _instance;

            }
        } 
        public ProductItems()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProductItems_Load(object sender, EventArgs e)
        {
            
        }
    }
}
