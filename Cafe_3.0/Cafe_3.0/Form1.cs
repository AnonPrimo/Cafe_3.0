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

            label_Yes_or_No.Text = "";
            current_money = 10;
            needed_money = 100;
            person = new Persons();
            tries = 3;
            food = new Food();
            this.pictureBox_Person.BackgroundImage = person.RandPers();

            if (ExitCafe())
                this.pictureBox_Person.BackgroundImage = person.RandPers();
           
        }


        public void Click_OK(object sender, EventArgs e)
        {
            tries--;

            label_Amount_of_Coins.Text = current_money.ToString("n");

            if (checkBox_IceCream.Checked == true)
                ch = 1;
            if (checkBox_Tea.Checked == true)
                ch = 2;
            if (checkBox_Coffee.Checked == true)
                ch = 3;

            if (food.CheckFood(ch))
            {
                label_Yes_or_No.Text = "Yes";
                this.pictureBox_Person.BackgroundImage = person.PersUp();
            }
            else
            {
                label_Yes_or_No.Text = "No";
                this.pictureBox_Person.BackgroundImage = person.PersDown();
            }

            

            
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

    

        private void pictureBox_coins_Click(object sender, EventArgs e)
        {
            person.RandPers(); 
        }
    }
}
