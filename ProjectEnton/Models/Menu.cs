﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEnton.Models
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }

        public Menu()
        {
            MenuItems = new List<MenuItem>();


            /*MenuItems.Add(new MenuItem("\uE1CE", "Menu Item 1", typeof(Page1View)));
            MenuItems.Add(new MenuItem("\uE1CE", "Menu Item 2", typeof(Page2View)));
            MenuItems.Add(new MenuItem("\uE1CE", "Menu Item 3", typeof(Page3View)));
            MenuItems.Add(new MenuItem("\uE1CE", "Menu Item 4", typeof(Page4View)));*/
        }
    }
}
