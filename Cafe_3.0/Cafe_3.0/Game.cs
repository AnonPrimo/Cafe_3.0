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
    class Game
    {
        int current_money;
        int needed_money;
        Persons person;
        int tries;
        Food food;

        public Game(int a)
        {
            current_money = a;
            needed_money = 100;
            person = new Persons();
            tries = 3;
            food = new Food();
        }

        public void StartGame()
        {
            person.RandPers();
            food = new Food();

            //if (checkBox_Coffe)
            //    if (food.CheckFood(3))
            //        person = person.PersUp();


        }

        private void CheckGame()
        {
           for(int i = 0; i < 6; ++i)
               // if(i)
        }

    }
}
