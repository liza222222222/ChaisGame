using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace _2
{
    
    class Program
    {
        static void Main(string[] args)
        {

            BuildingFactory KNOKFactory1 = new KNOKFactory();
            BuildingFactory NiledFactory1 = new NiledFactory();
            BuildingFactory PikopFactory1 = new PikopFactory();
            char n = ' ';
            while (n!='4')
            {
                Console.WriteLine("Если хотите построить дом в классическом стиле нажмите 1");
                Console.WriteLine("Если хотите построить дом в готическом стиле нажмите 2");
                Console.WriteLine("Если хотите построить дом стиле китайсокм нажмите 3");
                Console.WriteLine("Хотите выйти нажмите 4");
                n =Convert.ToChar( Console.ReadLine());

                if (n=='1')
                {
                    Console.Write("Строительная компания KNOK ");
                    Building classik = new Building(KNOKFactory1);
                    classik.Buildd();
                    Console.WriteLine();

                }
                else if (n == '3')
                {
                    Console.Write("Строительная компания Niled ");
                    Building baroque = new Building(PikopFactory1);
                    baroque.Buildd();
                    Console.WriteLine();
                }
                else if (n == '2')
                {
                    Console.Write("Строительная компания Pikop ");
                    Building gothic = new Building(NiledFactory1);
                    gothic.Buildd();
                    Console.WriteLine();
                   Console.Write("Мы случайно построили Notre-Dame De Paris(");
                    Console.WriteLine();
                    Console.WriteLine();
                }

            }
        }
    }
}
