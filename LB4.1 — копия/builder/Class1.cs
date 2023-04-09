using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace builder
{
    interface ICloneablePrototype
    {
        object Clone(); // метод клонирования
    }
    public class Product: ICloneablePrototype
    {
        public object Clone()
        {
            Product p = new Product();
            p.s = this.s;
            p.pict = this.pict;
           return new Product();
        }
        public List<string> s = new List<string>();
        public List<PictureBox> pict = new List<PictureBox>();
        

        public Product()
        {
            PictureBox p1 = new PictureBox();
            PictureBox p2 = new PictureBox();
            PictureBox p3 = new PictureBox();
            PictureBox p4 = new PictureBox();
            s.Add(null);
            s.Add(null);
            s.Add(null);
            s.Add(null);
            pict.Add(p1);
            pict.Add(p2);
            pict.Add(p3);
            pict.Add(p4);
        }
       
        public void zap (List<Panel> panel,List <Label> label)
        {
            for (int i = 0; i < panel.Count; i++)
            {
                panel[i].BackgroundImage = pict[i].BackgroundImage;
                label[i].Text = s[i];
            }
        }

    }
    // Интерфейс строителя, определяющий методы для пошагового построения продукта    
    public interface IBuilder
    {
        void Comp1();
        void Comp2(); 
        void Comp3();
        void Comp4();
        Product GetResult();
    }
    // Класс конкретного строителя, который реализует интерфейс строителя    
    public class Napoletana : IBuilder
    {
        private Product product = new Product();

        public void Comp2()
        {
        
            for (int i = 0; i < product.s.Count; i++)
            {
               
                if (product.s[i] == null)
                {
                    product.s[i] = "Cheese";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_37;
                    break;
                }
            }
        }
        public void Comp3()
        {
           
            for (int i = 0; i < product.s.Count; i++)
            {
               
                if (product.s[i] == null)
                {
                    product.s[i] = "Оlives";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_39;
                    break;
                }
            }
        }
        public void Comp4()
        {
            for (int i = 0; i < product.s.Count; i++)
            {
                if (product.s[i] == null)
                {
                    product.s[i] = "Salami";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_46;
                    break;
                }
            }
        }
        public void BuildTomatoes()
        {
            for (int i = 0; i < product.s.Count; i++)
            {
                if (product.s[i] == null)
                {
                    product.s[i] = "Mushrooms";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_38;
                    break;
                }
            }
        }
        public void BuildBacon()
        {
            for (int i = 0; i < product.s.Count; i++)
            {
                if (product.s[i] == null)
                {
                    product.s[i] = "Bacon";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_47;
                    break;
                }
            }
        }
        public void Comp1()
        {
           
            for (int i = 0; i < product.s.Count; i++)
            {
                if (product.s[i] == null)
                {
                    product.s[i] = "Sauce";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_36;
                    break;
                }
            }
        }
        public Product GetResult()
        {
            return product;
        }
    }
    public class Siciliana : IBuilder
    {
        private Product product = new Product();
        public void Comp2()
        {

            for (int i = 0; i < product.s.Count; i++)
            {

                if (product.s[i] == null)
                {
                    product.s[i] = "Cheese";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_37;
                    break;
                }
            }
        }
        public void Comp4()
        {
            for (int i = 0; i < product.s.Count; i++)
            {
                if (product.s[i] == null)
                {
                    product.s[i] = "Mushrooms";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_38;
                    break;
                }
            }
        }
        public void Comp3()
        {
            for (int i = 0; i < product.s.Count; i++)
            {
                if (product.s[i] == null)
                {
                    product.s[i] = "Bacon";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_47;
                    break;
                }
            }
        }
        public void Comp1()
        {

            for (int i = 0; i < product.s.Count; i++)
            {
                if (product.s[i] == null)
                {
                    product.s[i] = "Sauce";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_36;
                    break;
                }
            }
        }
        public Product GetResult()
        {
            return product;
        }
    }
    public class Calzone : IBuilder
    {
        private Product product = new Product();

        public void Comp1()
        {

            for (int i = 0; i < product.s.Count; i++)
            {

                if (product.s[i] == null)
                {
                    product.s[i] = "Cheese";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_37;
                    break;
                }
            }
        }
        public void Comp2()
        {

            for (int i = 0; i < product.s.Count; i++)
            {

                if (product.s[i] == null)
                {
                    product.s[i] = "Оlives";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_39;
                    break;
                }
            }
        }
        public void Comp4()
        {
            for (int i = 0; i < product.s.Count; i++)
            {
                if (product.s[i] == null)
                {
                    product.s[i] = "Salami";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_46;
                    break;
                }
            }
        }
      
        public void Comp3()
        {
            for (int i = 0; i < product.s.Count; i++)
            {
                if (product.s[i] == null)
                {
                    product.s[i] = "Bacon";
                    product.pict[i].BackgroundImage = Resource1.Без_имени_47;
                    break;
                }
            }
        }
       
        public Product GetResult()
        {
            return product;
        }
    }
    // Класс директора, который определяет порядок построения продукта с помощью строителя
    public class Director
    {
        public Product Napoletana(IBuilder builder, Label label)
        {
            label.Text = "Napoletana";
            builder.Comp1();
            builder.Comp2();
            builder.Comp3();
            builder.Comp4();
            return builder.GetResult();
        }
        public Product Calzone(IBuilder builder, Label label)
        {
            label.Text = "Calzone";
            builder.Comp1();
            builder.Comp2();
            builder.Comp3();
            builder.Comp4();

            return builder.GetResult();
        }
        public Product Siciliana(IBuilder builder, Label label)
        {
            label.Text = "Siciliana";
            builder.Comp1();
            builder.Comp2();
            builder.Comp3();
            builder.Comp4();

            return builder.GetResult();
        }

    }
}
