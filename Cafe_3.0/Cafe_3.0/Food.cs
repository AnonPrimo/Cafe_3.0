﻿using System;
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
    class Food
    {
        Random r = new Random();
        int f;

        public Food()
        {
            f = r.Next(1, 4);        
        }

        public bool CheckFood(int i)
        {
            f = r.Next(1, 4);
            if (f == i)
                return true;
            return false;
        }
 
    }
}
