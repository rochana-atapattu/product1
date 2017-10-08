using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarasaraSystem.SubInterface.Sales
{
    public partial class CustomMsgBox : Form
    {
       
       
        public CustomMsgBox()
        {
            InitializeComponent();
            
        }
       
        static CustomMsgBox MsgBox;
        static DialogResult result=DialogResult.No;
        public static DialogResult Show(string Text,string btnYes)
        {
            
                MsgBox = new CustomMsgBox();
                MsgBox.MsgBoxLabel.Text = Text;
                MsgBox.Yesbtn.Text = btnYes;
               
                MsgBox.ShowDialog();
                return result;
            
        }

        private void Yesbtn_Click(object sender, EventArgs e)
        {


            this.Close();
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomMsgBox_Load(object sender, EventArgs e)
        {
            
        }
        
      

        
    }
}
