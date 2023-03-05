using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChairLib
{
    public abstract class Level
    {
        public int col_stul, col_kstul, col_ustul;
        public string proverka(List<char> zap, int chis, PictureBox pict, Label l)
        {
            string pobeda = "";
            if (zap[chis - 1] == '+')
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/5a1ca3ad560677.9600813615118263493524.png");
                l.Text = "Это оно!!!!!!!!";
                pobeda = "aua";

            }
            else if (zap[chis - 1] == '/')
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Animated-Bomb-Transparent.png");
                l.Text = "Это же.....БОМБААААА...БЕЖИМ!!!!";
                pobeda = "t";
            }
            else
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Poop-Transparent-Free-PNG.png");
                l.Text = "Такое.... Думаю нам это не подойдет";
                pobeda = "ffffff";
            }
            return pobeda;
        }
    }
    public class level1 : Level
    {
        public string proverka1(List<char> zap, int chis, PictureBox pict, Label l)
        {
            string pobeda = "";
            if (zap[chis - 1] == '+')
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/5a1ca3ad560677.9600813615118263493524.png");
                l.Text = "Это оно!!!!!!!!";
                pobeda = "aua";

            }
            else if (zap[chis - 1] == '/')
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Animated-Bomb-Transparent.png");
                l.Text = "Это же.....БОМБААААА...БЕЖИМ!!!!";
                pobeda = "t";
            }
            else
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Poop-Transparent-Free-PNG.png");
                l.Text = "Такое.... Думаю нам это не подойдет";
                pobeda = "ffffff";
            }
            return pobeda;
        }
    }
    public class level2 : Level
    {
        public string proverka2(List<char> zap, int chis, PictureBox pict, Label l)
        {
            string pobeda = "";
            if (zap[chis - 1] == '+')
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/5a1ca3ad560677.9600813615118263493524.png");
                l.Text = "Это оно!!!!!!!!";
                pobeda = "aua";

            }
            else if (zap[chis - 1] == '/')
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Animated-Bomb-Transparent.png");
                l.Text = "Это же.....БОМБААААА...БЕЖИМ!!!!";
                pobeda = "t";
            }
            else
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Poop-Transparent-Free-PNG.png");
                l.Text = "Такое.... Думаю нам это не подойдет";
                pobeda = "ffffff";
            }
            return pobeda;
        }
    }
    public class level3 : Level
    {
        public string proverka3(List<char> zap, int chis, PictureBox pict, Label l)
        {
            string pobeda = "";
            if (zap[chis - 1] == '+')
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/5a1ca3ad560677.9600813615118263493524.png");
                l.Text = "Это оно!!!!!!!!";
                pobeda = "aua";

            }
            else if (zap[chis - 1] == '/')
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Animated-Bomb-Transparent.png");
                l.Text = "Это же.....БОМБААААА...БЕЖИМ!!!!";
                pobeda = "t";
            }
            else
            {
                pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Poop-Transparent-Free-PNG.png");
                l.Text = "Такое.... Думаю нам это не подойдет";
                pobeda = "ffffff";
            }
            return pobeda;
        }
    }
}
