using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChairLib
{
    public abstract class KChair
    {
        public List<string> clue = new List<string>();
        Image filling;
        public void zap()
        {
            clue.Add("Тебе не кажется он странным?");
            clue.Add("У него зловещая аура...");
            clue.Add("Звезды мне сегодня сказали, что на него лучше не нажимать");
            clue.Add("Он меня пугает!");
            clue.Add("В нем явно что-то злое...");
            clue.Add("Прошу только не его!");
            clue.Add("Я боялся что ты его выберешь...");
        }
        public void CreateChair(PictureBox pict)
        {
            pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Chair-Free-PNG-Image.png");
        }
        public void CreateClue(PictureBox pict)
        {

        }
    }
    public class Level1KChair : KChair
    {
        public int col_stul = 5;
        public int col_kstul = 1;
        public int col_ustul = 1;
    }
    public class Level2KChair : KChair
    {
        public int col_stul = 10;
        public int col_kstul = 1;
        public int col_ustul = 1;
    }
    public class Level3KChair : KChair
    {
        public int col_stul = 10;
        public int col_kstul = 3;
        public int col_ustul = 1;
    }
}
