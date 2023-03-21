using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace singlton
{
    public class Singleton
    {
        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
                return _instance;
            }
            else
            {
                return null;
            }
        }
        protected Singleton()
        {
        }

        private static Singleton _instance = null;
        public string[] k;
        public void file(string s)
        {
            List<string> k1 = new List<string>();
            if (s != "")
            {
                k1.Add(s);
                File.AppendAllLines("E:/NANI/programmer/кпз/spy.txt", k1);
            }
            else
            {
                k = File.ReadAllLines("E:/NANI/programmer/кпз/spy.txt");

            }
        }

    }
}
