using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cafe_3._0
{
    public partial class Form1 : Form
    {
        Food food;
        int current_money;
        int needed_money;
        Persons person;
        Thread t;
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

            ExitCafe();


        }

        public void ExitCafe()
        {
            if ((tries < 0) || (person.Mood() == 0) || (person.Mood() == 3))
            {
                current_money += CheckMood();
                tries = 3;
                Thread.Sleep(1000);
                this.pictureBox_Person.BackgroundImage = person.RandPers();
                label_Yes_or_No.Text = "";
                label_Amount_of_Coins.Text = current_money.ToString("n");
            }

            if (current_money < 0)
            {
                MessageBox.Show("You lose!");
                this.Close();
            }
            else
            if (current_money >= 100)
            {
                MessageBox.Show("You win!");
                this.Close();
            }

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
