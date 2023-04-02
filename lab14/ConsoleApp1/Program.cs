using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void max1()
        {
            int max = chis1.Max();
            Console.WriteLine("Максимальне: "+ max);
        }
        static void min()
        {
            int min = chis1.Min();
            Console.WriteLine("Мiнiмальне: "+ min);
        }
        static void vivod()
        {
            string s = "";
            for (int i = 0; i < chis1.Count; i++)
            {
                s += chis1[i] + " ";
               
            }
            Console.WriteLine(s);
        }
        static Thread t1 = new Thread(() =>
        {
            vivod();
            max1();
           
        });

       static  Thread t2 = new Thread(() =>
        {
            
            min();
        });
        static List<int> chis1 = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть елемент або натиснiть '=': ");
            string chis = Console.ReadLine();

            while (chis!="=")
            {
                chis1.Add(Convert.ToInt32(chis));
                chis = Console.ReadLine();
            }

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
    }
}
