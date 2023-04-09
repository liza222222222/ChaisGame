using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Windows.Forms;

namespace lb7
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        Graphics g;
        Tree[] t = new Tree[500];
        Param[] p = new Param[2];
        ParamOneYearTree p1 = new ParamOneYearTree();
        ParamTwoYearTree p2 = new ParamTwoYearTree();
        int count = 0;
        Random r = new Random();
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {

            // r.Next(10, 800);

            if (r.Next(0, 10) % 2 == 0)
                t[count] = new Tree(r.Next(10, 1500), r.Next(10, 1500), p1);
            else
                t[count] = new Tree(r.Next(10, 1500), r.Next(10, 1500), p2);

            g.DrawImage(t[count].p.pic, new Rectangle(t[count].x, t[count].y, t[count].p.h, 70));
            if (count < 499)
                count++;
            else
                timer1.Stop();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int po = r.Next(1, 200);

            if (t[po] != null && t[po].p.h < 120)
            {
                SolidBrush b = new SolidBrush(Color.YellowGreen);

                //g.FillRectangle(b, t[po].x, t[po].y, t[po].p.h, t[po].p.h);
                int d= t[po].p.h + 35;
                g.DrawImage(t[po].p.pic, new Rectangle(t[po].x, t[po].y, d, d));
               
            }
        }
    }
}
