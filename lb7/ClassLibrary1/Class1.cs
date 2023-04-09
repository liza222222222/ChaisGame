using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    
        public class Param
        {
            public int h;
            public Bitmap pic;
        }

        public class ParamOneYearTree : Param
        {
            public ParamOneYearTree()
            {
                h =70;
                pic = new Bitmap(@"E:\NANI\programmer\хлам\free-png.ru-161.png");
            }
        }
        public class ParamTwoYearTree : Param
        {
            public ParamTwoYearTree()
            {
                h = 70;
                pic = new Bitmap(@"E:\NANI\programmer\хлам\—Pngtree—beautifully hand-painted watercolor flowers_309331.png");
            }
        }
        public class Tree
        {
            public int x, y;
            //------------
           public int h;
             //public Bitmap pic;*/
            public Param p;
            //------------
            public Tree()
            {
                // h = 10;
                x = 0; y = 0;
            }
            /* public Tree(int x, int y, int ah, Bitmap apic)
             {
                 h = ah;
                 pic = apic;
                 this.x = x;
                 this.y = y;
             }*/
            public Tree(int x, int y, Param p)
            {
                this.p = p;
                this.x = x;
                this.y = y;
            }
        }
    }

