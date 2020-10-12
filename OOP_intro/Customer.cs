using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP_intro
{
    class Customer
    {
        private static String name;
        private static List<Product> productList = new List<Product>();
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Product> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }

    }
}