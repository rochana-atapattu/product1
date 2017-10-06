using Harasara;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem
{
    public partial class mainGUI : Form
    {

        Timer t = new Timer();
        int WIDTH =300 ,HEIGHT=300, secHAND=140,minHand=110,hrHand=80;
        //centre
        int cx, cy;
        Bitmap bmp;
        Graphics g;






        public mainGUI()
        {
            InitializeComponent();
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void mainGUI_Load(object sender, EventArgs e)
        {
            //create bitmap

            bmp = new Bitmap(WIDTH+1,HEIGHT+1);
            //centre
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //backroll
            this.BackColor = Color.White;

            //timer
            t.Interval = 1000; //inmelesecond
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

        }
        private void t_Tick(object sender,EventArgs e)
        {
            g = Graphics.FromImage(bmp);

            //getTime
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            int[] handcoord = new int[2];

            //clear
            g.Clear(Color.White);

            //draw Circle
            g.DrawEllipse(new Pen(Color.Black, 3f), 0, 0,WIDTH,HEIGHT);

            //draw figure
            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new Point(140, 1));
            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new Point(286, 140));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new Point(142, 282));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new Point(0, 140));

            //secondhand
            handcoord = msCoord(ss, secHAND);
            g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handcoord[0], handcoord[1]));

            //minuteHand

            handcoord = msCoord(mm,minHand);
            g.DrawLine(new Pen(Color.Green, 2f), new Point(cx, cy), new Point(handcoord[0], handcoord[1]));

            //hourHand
            handcoord = hrCoord(hh%12,mm,hrHand);
            g.DrawLine(new Pen(Color.Gray, 4f), new Point(cx, cy), new Point(handcoord[0], handcoord[1]));


            //load bmp picture box

            clock.Image = bmp;

            g.Dispose();




        }

        //cord for minute and second Hand
        private int[]  msCoord(int val,int hlen)
        {
            int[] coord = new int[2];
            val *= 6;

            if( val >=0 && val <=180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy -(int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }

            return coord;
        }

        //coord for HourHand
        private int[] hrCoord(int hval,int mval, int hlen)
        {
            int[] coord = new int[2];
            //each hour makes 30 degees
            //each min makes 0.5 degrees

            int val = (int)((hval * 30) + (mval * 0.5));


            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }

            return coord;
        }

        private void maximizeWindow_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
        }

        private void Sales_Click(object sender, EventArgs e)
        {
           login s = new login();
           s.Show();
           this.Hide();

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            
        }


    }
}
