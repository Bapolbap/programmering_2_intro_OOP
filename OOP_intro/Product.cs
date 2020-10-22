using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP_intro
{
    class Product
    {
        private String name;

        public virtual string[] productList()
        {
            string[] products = { "annat" };
            return products;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Food : Product
    {
        public override string[] productList()
        {
            string[] products = { "salad", "bröd", "kött", "tofu", "godis" };
            return products;
        }
    }
    

    class Beverage : Product
    {
        public override string[] productList()
        {
            string[] products = { "vatten", "smoothie", "kaffe", "cola", "mjölk" };
            return products;
        }
    }

    class Toy : Product
    {
        public override string[] productList()
        {
            string[] products = { "lego", "kortlek", "brädspel", "tv-spel", "intercontinental ballistic missile" };
            return products;
        }
    }
}
