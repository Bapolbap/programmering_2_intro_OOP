using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP_intro
{
    class Product
    {
        private String name;
        private int price;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
