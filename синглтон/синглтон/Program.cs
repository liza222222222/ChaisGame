using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using singlton;

namespace синглтон
{
    
        class Program
    {
       
        static void Main(string[] args)
        { char n = ' ';
            Singleton singlton = Singleton.Instance();
            int d = 0;
            while (n!='8')
            {
               
                if (d<7)
                {
                    Console.WriteLine("Хотите пойти на свидание со второй половинкой нажмите - 1");
                    Console.WriteLine("Хотите пойти на работу нажмите - 2");
                    Console.WriteLine("Хотите пойти в бар нажмите - 3");
                    Console.WriteLine("Хотите поехать на пляж нажмите - 4");
                    Console.WriteLine("Хотите лежать весь день и смотреть фильмы нажмите - 5");
                    Console.WriteLine("Не хотите продолжать жить нажмите - 8");
                }
                else
                {
                    Console.WriteLine("Хотите пойти на свидание со второй половинкой нажмите - 1");
                    Console.WriteLine("Хотите пойти на работу нажмите - 2");
                    Console.WriteLine("Хотите пойти в бар нажмите - 3");
                    Console.WriteLine("Хотите поехать на пляж нажмите - 4");
                    Console.WriteLine("Хотите лежать весь день и смотреть фильмы нажмите - 5");
                    Console.WriteLine("Вам кажется что за вами следят. Вы нашли записку. Хотите прочитать нажмите - 6");
                    Console.WriteLine("Не хотите продолжать жить нажмите - 8");
                }

                n = Convert.ToChar(Console.ReadLine());

                switch (n)
                {
                    case '1':
                        singlton.file("Сегодня "+d+".03|Он пошел гулять с каким-то мужчиной. Похоже у них свидание!");
                        break;
                    case '2':
                        singlton.file("Сегодня " + d + ".03|Он снова провел весь день на работе...");
                        break;
                    case '3':
                        singlton.file("Сегодня " + d + ".03|Почти весь день он был в баре. Возможно он поссорился с парнем");
                        break;
                    case '4':
                        singlton.file("Сегодня " + d + ".03|Он был на пляже... один... похoже они расстались");
                        break;
                    case '5':
                        singlton.file("Сегодня " + d + ".03|Он был сегодня весь день дома. Страдает парень...");
                        break;
                    case '6':
                        singlton.file("");
                        Console.WriteLine();
                        for (int i = 0; i < singlton.k.Length; i++)
                        {
                            
                            Console.WriteLine( singlton.k[i]);
                            Console.WriteLine();
                        }
                        break;

                }
                d++;
            }
            Console.WriteLine("Он выбросился с окна 💀");
            File.Delete ("E:/NANI/programmer/кпз/spy.txt");
        }
    }
}
