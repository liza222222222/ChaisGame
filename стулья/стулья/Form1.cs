using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChairLib;

namespace стулья
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Top = 481;
            if (level==1)
            {
                for (int i = 0; i < 5; i++)
                {
                    pb[i].Visible = true;
                    pb[i].Enabled = true;
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    pb[i].Visible = true;
                    pb[i].Enabled = true;
                }
            }

            pictureBox11.Visible = true;
        }
        public List<PictureBox> pb = new List<PictureBox>();
        public List<char> zap = new List<char>();
        private void Form1_Load(object sender, EventArgs e)
        {
            nchair1.zap();
            nchair2.zap();
            nchair3.zap();
            uchair1.zap();
            uchair2.zap();
            uchair3.zap();
            kchair1.zap();
            kchair2.zap();
            kchair3.zap();
            
            panel1.Top = 84;
            pb.Add(pictureBox1);
            pb.Add(pictureBox2);
            pb.Add(pictureBox3);
            pb.Add(pictureBox4);
            pb.Add(pictureBox5);
            pb.Add(pictureBox10);
            pb.Add(pictureBox9);
            pb.Add(pictureBox8);
            pb.Add(pictureBox7);
            pb.Add(pictureBox6);

        }
        public Level1NChair nchair1 = new Level1NChair();
        public Level2NChair nchair2 = new Level2NChair();
        public Level3NChair nchair3 = new Level3NChair();
        public Level1UChair uchair1 = new Level1UChair();
        public Level2UChair uchair2 = new Level2UChair();
        public Level3UChair uchair3 = new Level3UChair();
        public Level1KChair kchair1 = new Level1KChair();
        public Level2KChair kchair2 = new Level2KChair();
        public Level3KChair kchair3 = new Level3KChair();
        public int level = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            level = 1;
            for (int i = 0; i < nchair1.col_stul; i++)
            {
                nchair1.CreateChair(pb[i]);
                zap.Add(' ');
            }
            Random r = new Random();
            zap[r.Next(0, nchair1.col_stul)] = '+';
            int l = r.Next(0, nchair1.col_stul);
            do
            {
                if (zap[l]==' ')
                {
                    zap[l] = '/';
                }
                else
                {
                    l = r.Next(0, nchair1.col_stul);
                }
            } while (zap[l]!='/');

            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            string s = "";
            int col = 0;
            if (level==1)
            {
                col = nchair1.col_stul;
            }
            else if (level == 2)
            {
                col = nchair2.col_stul;
            }
            else
            {
                col = nchair3.col_stul;
            }
            for (int i = 0; i < col; i++)
            {
                if (pictureBox1.Tag== pb[i].Tag&&zap[i]=='+')
                {
                    Random r = new Random();
                   s=uchair3.clue[r.Next(0, uchair3.clue.Count)];

                }
                else if (pictureBox1.Tag == pb[i].Tag && zap[i] == '/')
                {
                    Random r = new Random();
                    s = kchair3.clue[r.Next(0, kchair3.clue.Count)];
                }
                else if (pictureBox1.Tag == pb[i].Tag && zap[i] == ' ')
                {
                    Random r = new Random();
                    s = nchair3.clue[r.Next(0, nchair3.clue.Count)];
                }
                
            }
            label1.Text = s;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            string s = "";
            int col = 0;
            if (level == 1)
            {
                col = nchair1.col_stul;
            }
            else if (level == 2)
            {
                col = nchair2.col_stul;
            }
            else
            {
                col = nchair3.col_stul;
            }
            for (int i = 0; i < col; i++)
            {
                if (pictureBox2.Tag == pb[i].Tag && zap[i] == '+')
                {
                    Random r = new Random();
                    s = uchair3.clue[r.Next(0, uchair3.clue.Count)];

                }
                else if (pictureBox2.Tag == pb[i].Tag && zap[i] == '/')
                {
                    Random r = new Random();
                    s = kchair3.clue[r.Next(0, kchair3.clue.Count)];
                }
                else if (pictureBox2.Tag == pb[i].Tag && zap[i] == ' ')
                {
                    Random r = new Random();
                    s = nchair3.clue[r.Next(0, nchair3.clue.Count)];
                }

            }
            label1.Text = s;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            string s = "";
            int col = 0;
            if (level == 1)
            {
                col = nchair1.col_stul;
            }
            else if (level == 2)
            {
                col = nchair2.col_stul;
            }
            else
            {
                col = nchair3.col_stul;
            }
            for (int i = 0; i < col; i++)
            {
                if (pictureBox3.Tag == pb[i].Tag && zap[i] == '+')
                {
                    Random r = new Random();
                    s = uchair3.clue[r.Next(0, uchair3.clue.Count)];

                }
                else if (pictureBox3.Tag == pb[i].Tag && zap[i] == '/')
                {
                    Random r = new Random();
                    s = kchair3.clue[r.Next(0, kchair3.clue.Count)];
                }
                else if (pictureBox3.Tag == pb[i].Tag && zap[i] == ' ')
                {
                    Random r = new Random();
                    s = nchair3.clue[r.Next(0, nchair3.clue.Count)];
                }

            }
            label1.Text = s;

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            string s = "";
            int col = 0;
            if (level == 1)
            {
                col = nchair1.col_stul;
            }
            else if (level == 2)
            {
                col = nchair2.col_stul;
            }
            else
            {
                col = nchair3.col_stul;
            }
            for (int i = 0; i < col; i++)
            {
                if (pictureBox4.Tag == pb[i].Tag && zap[i] == '+')
                {
                    Random r = new Random();
                    s = uchair3.clue[r.Next(0, uchair3.clue.Count)];

                }
                else if (pictureBox4.Tag == pb[i].Tag && zap[i] == '/')
                {
                    Random r = new Random();
                    s = kchair3.clue[r.Next(0, kchair3.clue.Count)];
                }
                else if (pictureBox4.Tag == pb[i].Tag && zap[i] == ' ')
                {
                    Random r = new Random();
                    s = nchair3.clue[r.Next(0, nchair3.clue.Count)];
                }

            }
            label1.Text = s;

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            string s = "";
            int col = 0;
            if (level == 1)
            {
                col = nchair1.col_stul;
            }
            else if (level == 2)
            {
                col = nchair2.col_stul;
            }
            else
            {
                col = nchair3.col_stul;
            }
            for (int i = 0; i < col; i++)
            {
                if (pictureBox5.Tag == pb[i].Tag && zap[i] == '+')
                {
                    Random r = new Random();
                    s = uchair3.clue[r.Next(0, uchair3.clue.Count)];

                }
                else if (pictureBox5.Tag == pb[i].Tag && zap[i] == '/')
                {
                    Random r = new Random();
                    s = kchair3.clue[r.Next(0, kchair3.clue.Count)];
                }
                else if (pictureBox5.Tag == pb[i].Tag && zap[i] == ' ')
                {
                    Random r = new Random();
                    s = nchair3.clue[r.Next(0, nchair3.clue.Count)];
                }

            }
            label1.Text = s;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            string s = "";
            int col = 0;
            if (level == 1)
            {
                col = nchair1.col_stul;
            }
            else if (level == 2)
            {
                col = nchair2.col_stul;
            }
            else
            {
                col = nchair3.col_stul;
            }
            for (int i = 0; i < col; i++)
            {
                if (pictureBox10.Tag == pb[i].Tag && zap[i] == '+')
                {
                    Random r = new Random();
                    s = uchair3.clue[r.Next(0, uchair3.clue.Count)];

                }
                else if (pictureBox10.Tag == pb[i].Tag && zap[i] == '/')
                {
                    Random r = new Random();
                    s = kchair3.clue[r.Next(0, kchair3.clue.Count)];
                }
                else if (pictureBox10.Tag == pb[i].Tag && zap[i] == ' ')
                {
                    Random r = new Random();
                    s = nchair3.clue[r.Next(0, nchair3.clue.Count)];
                }

            }
            label1.Text = s;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            string s = "";
            int col = 0;
            if (level == 1)
            {
                col = nchair1.col_stul;
            }
            else if (level == 2)
            {
                col = nchair2.col_stul;
            }
            else
            {
                col = nchair3.col_stul;
            }
            for (int i = 0; i < col; i++)
            {
                if (pictureBox9.Tag == pb[i].Tag && zap[i] == '+')
                {
                    Random r = new Random();
                    s = uchair3.clue[r.Next(0, uchair3.clue.Count)];

                }
                else if (pictureBox9.Tag == pb[i].Tag && zap[i] == '/')
                {
                    Random r = new Random();
                    s = kchair3.clue[r.Next(0, kchair3.clue.Count)];
                }
                else if (pictureBox9.Tag == pb[i].Tag && zap[i] == ' ')
                {
                    Random r = new Random();
                    s = nchair3.clue[r.Next(0, nchair3.clue.Count)];
                }

            }
            label1.Text = s;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            string s = "";
            int col = 0;
            if (level == 1)
            {
                col = nchair1.col_stul;
            }
            else if (level == 2)
            {
                col = nchair2.col_stul;
            }
            else
            {
                col = nchair3.col_stul;
            }
            for (int i = 0; i < col; i++)
            {
                if (pictureBox8.Tag == pb[i].Tag && zap[i] == '+')
                {
                    Random r = new Random();
                    s = uchair3.clue[r.Next(0, uchair3.clue.Count)];

                }
                else if (pictureBox8.Tag == pb[i].Tag && zap[i] == '/')
                {
                    Random r = new Random();
                    s = kchair3.clue[r.Next(0, kchair3.clue.Count)];
                }
                else if (pictureBox8.Tag == pb[i].Tag && zap[i] == ' ')
                {
                    Random r = new Random();
                    s = nchair3.clue[r.Next(0, nchair3.clue.Count)];
                }

            }
            label1.Text = s;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            string s = "";
            int col = 0;
            if (level == 1)
            {
                col = nchair1.col_stul;
            }
            else if (level == 2)
            {
                col = nchair2.col_stul;
            }
            else
            {
                col = nchair3.col_stul;
            }
            for (int i = 0; i < col; i++)
            {
                if (pictureBox7.Tag == pb[i].Tag && zap[i] == '+')
                {
                    Random r = new Random();
                    s = uchair3.clue[r.Next(0, uchair3.clue.Count)];

                }
                else if (pictureBox7.Tag == pb[i].Tag && zap[i] == '/')
                {
                    Random r = new Random();
                    s = kchair3.clue[r.Next(0, kchair3.clue.Count)];
                }
                else if (pictureBox7.Tag == pb[i].Tag && zap[i] == ' ')
                {
                    Random r = new Random();
                    s = nchair3.clue[r.Next(0, nchair3.clue.Count)];
                }

            }
            label1.Text = s;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            string s = "";
            int col = 0;
            if (level == 1)
            {
                col = nchair1.col_stul;
            }
            else if (level == 2)
            {
                col = nchair2.col_stul;
            }
            else
            {
                col = nchair3.col_stul;
            }
            for (int i = 0; i < col; i++)
            {
                if (pictureBox6.Tag == pb[i].Tag && zap[i] == '+')
                {
                    Random r = new Random();
                    s = uchair3.clue[r.Next(0, uchair3.clue.Count)];

                }
                else if (pictureBox6.Tag == pb[i].Tag && zap[i] == '/')
                {
                    Random r = new Random();
                    s = kchair3.clue[r.Next(0, kchair3.clue.Count)];
                }
                else if (pictureBox6.Tag == pb[i].Tag && zap[i] == ' ')
                {
                    Random r = new Random();
                    s = nchair3.clue[r.Next(0, nchair3.clue.Count)];
                }

            }
            label1.Text = s;

        }
        public string pobeda;
        public level1 lev = new level1();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pobeda=lev.proverka(zap, 1, pictureBox12, label1 );
            if (pobeda!= "ffffff")
            {
                timer1.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            level = 2;
            for (int i = 0; i < nchair2.col_stul; i++)
            {
                nchair1.CreateChair(pb[i]);
                zap.Add(' ');
            }
            Random r = new Random();
            zap[r.Next(0, nchair2.col_stul)] = '+';
            int l = r.Next(0, nchair2.col_stul);
            do
            {
                if (zap[l] == ' ')
                {
                    zap[l] = '/';
                }
                else
                {
                    l = r.Next(0, nchair2.col_stul);
                }
            } while (zap[l] != '/');

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            level = 3;
            for (int i = 0; i < nchair3.col_stul; i++)
            {
                nchair1.CreateChair(pb[i]);
                zap.Add(' ');
            }
            Random r = new Random();
            zap[r.Next(0, nchair3.col_stul)] = '+';
            int l = r.Next(0, nchair3.col_stul);
            int sch = 0;
            do
            {
                if (zap[l] == ' ')
                {
                    zap[l] = '/';
                    sch++;
                }
                else
                {
                    l = r.Next(0, nchair3.col_stul);
                }
            } while (sch!=3);

        
        }
        int sch = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sch == 0)
            {
                sch++;
            }
            else if (sch == 1) 
            {
                panel2.Visible = true;
                panel2.Top = 0;
                if (pobeda== "aua")
                {
                    label2.Text = "VICTORY";
                }
                else if(pobeda == "t")
                {
                    label2.Text = "НЕ VICTORY";
                }
                sch = 0;
                timer1.Stop();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pobeda = lev.proverka(zap, 2, pictureBox12, label1);
            if (pobeda != "ffffff")
            {
                timer1.Start();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            pobeda = lev.proverka(zap, 3, pictureBox12, label1);
            if (pobeda != "ffffff")
            {
                timer1.Start();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            pobeda = lev.proverka(zap, 4, pictureBox12, label1);
            if (pobeda != "ffffff")
            {
                timer1.Start();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pobeda = lev.proverka(zap, 5, pictureBox12, label1);
            if (pobeda != "ffffff")
            {
                timer1.Start();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            pobeda = lev.proverka(zap, 6, pictureBox12, label1);
            if (pobeda != "ffffff")
            {
                timer1.Start();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            pobeda = lev.proverka(zap, 7, pictureBox12, label1);
            if (pobeda != "ffffff")
            {
                timer1.Start();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            pobeda = lev.proverka(zap, 8, pictureBox12, label1);
            if (pobeda != "ffffff")
            {
                timer1.Start();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            pobeda = lev.proverka(zap, 9, pictureBox12, label1);
            if (pobeda != "ffffff")
            {
                timer1.Start();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            pobeda = lev.proverka(zap, 10, pictureBox12, label1);
            if (pobeda != "ffffff")
            {
                timer1.Start();
            }
        }
    }
}
