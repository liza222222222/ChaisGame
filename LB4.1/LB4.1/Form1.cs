using System;
using builder;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        List<Panel> panel = new List<Panel>();
        List<Label> label = new List<Label>();
        private void Form1_Load(object sender, EventArgs e)
        {
            label.Add(label2);
            label.Add(label3);
            label.Add(label4);
            label.Add(label5);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            pict = new List<PictureBox>();
            Director director = new Director();
            Napoletana builder = new Napoletana();
             product = director.Napoletana(builder, label1);
            product.zap(panel, label, pict);
            g = CreateGraphics();

            for (int i = 0; i < pict.Count; i++)
            {
                if (i == 0)
                {
                    g.DrawImage(Resource1.Без_имени_18, 26, 101, product.height, product.width);
                }

                g.DrawImage(pict[i].BackgroundImage, 26, 101, product.height, product.width);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pict = new List<PictureBox>();
            Director director = new Director();
            Calzone builder = new Calzone();
             product = director.Calzone(builder, label1);
            product.zap(panel, label, pict);
            g = CreateGraphics();

            for (int i = 0; i < pict.Count; i++)
            {
                if (i == 0)
                {
                    g.DrawImage(Resource1.Без_имени_18, 149, 101, product.height, product.width);
                }

                g.DrawImage(pict[i].BackgroundImage, 149, 101, product.height, product.width);

            }

        }
        Graphics g;
        public List<PictureBox> pict = new List<PictureBox>();

        
        Product product;
        private void button3_Click(object sender, EventArgs e)
        {
            pict = new List<PictureBox>();
            Director director = new Director();
            Siciliana builder = new Siciliana();
            product = director.Siciliana(builder, label1);
            product.zap(panel, label,pict);
            g = CreateGraphics();

            for (int i = 0; i < pict.Count; i++)
            {
                if (i==0)
                {
                    g.DrawImage(Resource1.Без_имени_18, 260, 101, product.height, product.width);
                }
                
                    g.DrawImage(pict[i].BackgroundImage, 260, 101, product.height, product.width);
                 
            }
           
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pict = new List<PictureBox>();
            Product clone = (Product) product.Clone();
            clone.zap(panel, label, pict);
            g = CreateGraphics();

            for (int i = 0; i < pict.Count; i++)
            {
                if (i == 0)
                {
                    g.DrawImage(Resource1.Без_имени_18, e.X, e.Y, product.height, product.width);
                }

                g.DrawImage(pict[i].BackgroundImage, e.X, e.Y, product.height, product.width);

            }
        }
    }
}
