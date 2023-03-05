using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChairLib
{
    public abstract class UChair
    {
        public List<string> clue = new List<string>();
        Image filling;
        public void zap()
        {

            clue.Add("У него такая добрая аура");
            clue.Add("Мне нравиться твой выбор");
            clue.Add("А знаешь, в нем что-то есть)");
            clue.Add("Очень интригующе!");
            clue.Add("Когда у коровы рождается теленок, она называет его ребенком, хотя он не человек");


        }
        public void CreateChair(PictureBox pict)
        {
            pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Chair-Free-PNG-Image.png");
        }
        public void CreateClue(PictureBox pict)
        {

        }
    }
    public class Level1UChair : UChair
    {

        public int col_stul = 5;
        public int col_kstul = 1;
        public int col_ustul = 1;
    }
    public class Level2UChair : UChair
    {
        public int col_stul = 10;
        public int col_kstul = 1;
        public int col_ustul = 1;
    }
    public class Level3UChair : UChair
    {
        public int col_stul = 10;
        public int col_kstul = 3;
        public int col_ustul = 1;
    }
}
