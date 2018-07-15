using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_3._0
{
    class Persons
    {
        Random r = new Random();
        Bitmap[,] person = new Bitmap[6, 4];

        public Persons()
        {
            person[0, 0] = Properties.Resources.boy_happy;
            person[0, 1] = Properties.Resources.boy_neutral;
            person[0, 2] = Properties.Resources.boy_cry;
            person[0, 3] = Properties.Resources.boy_angry;

            person[1, 0] = Properties.Resources.girl_happy;
            person[1, 1] = Properties.Resources.girl_neutral;
            person[1, 2] = Properties.Resources.girl_cry;
            person[1, 3] = Properties.Resources.girl_angry;

            person[2, 0] = Properties.Resources.man_happy;
            person[2, 1] = Properties.Resources.man_neutral;
            person[2, 2] = Properties.Resources.man_cry;
            person[2, 3] = Properties.Resources.man_angry;

            person[3, 0] = Properties.Resources.woman_happy;
            person[3, 1] = Properties.Resources.woman_neutral;
            person[3, 2] = Properties.Resources.woman_cry;
            person[3, 3] = Properties.Resources.woman_angry;

            person[4, 0] = Properties.Resources.grandfather_happy;
            person[4, 1] = Properties.Resources.grandfather_neutral;
            person[4, 2] = Properties.Resources.grandfather_cry;
            person[4, 3] = Properties.Resources.grandfather_angry;

            person[5, 0] = Properties.Resources.grandmather_happy;
            person[5, 1] = Properties.Resources.grandmather_neutral;
            person[5, 2] = Properties.Resources.grandmather_cry;
            person[5, 3] = Properties.Resources.grandmather_angry;
        }

        public Bitmap RandPers()
        {
            int i;
            int j;

            i = r.Next(0, 5);
            j = r.Next(1, 2);

            return person[i, j];
        }

        public Bitmap PersUp(int i, int j)
        {
            return person[i, j + 1];
        }

        public Bitmap PersDown(int i, int j)
        {
            return person[i, j - 1];
        }

        
    }
}
