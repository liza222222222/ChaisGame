using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChairLib
{
    public abstract class NChair
    {
        public List<string> clue = new List<string>();
        Image filling;
        public void zap()
        {
            clue.Add("Не думаю что оно тут(");
            clue.Add("Может попробуем еще раз");
            clue.Add("Мне кажется ты ошибаешься");
            clue.Add("Если это нужный стул, то 2+2=99!");
            clue.Add("Ты точно уверен?");
            clue.Add("Этот стул слишком обычный(");
            clue.Add("Не думаю что в нем взаправду что-то стоющее");
            clue.Add("Давай выберем какой-то другой");
            clue.Add("Думаю это совсем не то...");
            clue.Add("Почему бы нам не посмотреть еще?");

        }
        public void CreateChair(PictureBox pict)
        {
            pict.BackgroundImage = Image.FromFile("E:/NANI/programmer/хлам/Chair-Free-PNG-Image.png");
        }
        public void CreateClue(PictureBox pict)
        {

        }

    }
    public class Level1NChair : NChair
    {
        public int col_stul = 5;
        public int col_kstul = 1;
        public int col_ustul = 1;
    }
    public class Level2NChair : NChair
    {
        public int col_stul = 10;
        public int col_kstul = 1;
        public int col_ustul = 1;
    }
    public class Level3NChair : NChair
    {
        public int col_stul = 10;
        public int col_kstul = 3;
        public int col_ustul = 1;
    }
}
