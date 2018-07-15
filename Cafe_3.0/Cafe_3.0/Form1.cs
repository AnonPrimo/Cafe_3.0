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
    public partial class Form1 : Form
    {
        Food food;
        int current_money;
        int needed_money;
        Persons person;

        int tries;
        int ch;
        
        public Form1()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.cafe_background;

            current_money = 10;
            needed_money = 100;
            person = new Persons();
            tries = 3;
            food = new Food();
            this.pictureBox_Person.BackgroundImage = person.CurrentBitmap;//Properties.Resources.boy_angry;
        }


        public void Click_OK(object sender, EventArgs e)
        {
            tries--;
            if (checkBox_IceCream.Enabled)
                ch = 1;
            if (checkBox_Tea.Enabled)
                ch = 2;
            if (checkBox_Coffee.Enabled)
                ch = 3;

            if (food.CheckFood(ch))
                person.PersUp();
            else
                person.PersDown();

            if (ExitCafe())
                this.pictureBox_Person.BackgroundImage = person.RandPers();

        }

        public Boolean ExitCafe()
        {
            if ((tries == 0) || (person.Mood() == 0) || (person.Mood() == 3))
            {
                current_money += CheckMood();
                tries = 3;
                return true;
            }
            return false;
             
        }
       
        public int CheckMood()
        {
            switch (person.Mood())
            {
                case 0: return 30;
                case 1: return 20;
                case 2: return 10;
                case 3: return -10;
            }
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_coins_Click(object sender, EventArgs e)
        {
            person.RandPers(); 
        }
    }
}
