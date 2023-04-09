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

            panel.Add(panel2);
            panel.Add(panel3);
            panel.Add(panel4);
            panel.Add(panel5);
            label.Add(label2);
            label.Add(label3);
            label.Add(label4);
            label.Add(label5);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            Napoletana builder = new Napoletana();
            var product = director.Napoletana(builder, label1);
            product.zap(panel, label);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            Calzone builder = new Calzone();
            var product = director.Calzone(builder, label1);
            product.zap(panel, label);
        }
        Graphics g;
        private void button3_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            Siciliana builder = new Siciliana();
            var product = director.Siciliana(builder, label1);
            product.zap(panel, label);
           // g = CreateGraphics();
            //g.DrawImage();
           // panel7 = panel1;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
