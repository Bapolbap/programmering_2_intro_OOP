using System;
using System.Collections;

namespace OOP_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(InitializeCustomer());
        }

        public static Customer InitializeCustomer()
        {
            Customer customer = new Customer();
            Console.WriteLine("vad heter du?");
            customer.Name = Console.ReadLine();
            return customer;
        }
        public static void Menu(Customer customer)
        {
            var menuChoice = 0;
            while (menuChoice != 2) 
            {
                menuChoice = 0;
                Console.WriteLine("vad vill du göra, " +  customer.Name + "?\n" +
                                   "1: köp en produkt\n" +
                                   "2: checka ut");
                menuChoice = GetUserInputBetweenInt(1, 2);
                switch (menuChoice)
                {
                    case 1: AddProduct(customer); break;
                    case 2: CustomerCheckout(customer); break;
                }
            }
        }

        public static void AddProduct(Customer customer)
        {
            //string productName;
            Console.WriteLine("vad vill du köpa?\n" + 
                                "1: mat\n" +
                                "2: dricka\n" +
                                "3: leksak\n" +
                                "4: annat");

            //låt användaren skriva in tal medans ProductTypeMenuChoice inte är mellan 1 - 4
            int productTypeMenuChoice = GetUserInputBetweenInt(1, 4);
            switch (productTypeMenuChoice)
            {
                case 1:
                    Food food = new Food();
                    food.Name = GetUserProductChoice(food);
                    customer.ProductList.Add(food);
                    break;
                case 2:
                    Beverage beverage = new Beverage();
                    beverage.Name = GetUserProductChoice(beverage);
                    customer.ProductList.Add(beverage);
                    break;
                case 3:
                    Toy toy = new Toy();
                    toy.Name = GetUserProductChoice(toy);
                    customer.ProductList.Add(toy);
                    break;
                case 4:
                    Product product = new Product();
                    product.Name = GetUserProductChoice(product);
                    customer.ProductList.Add(product);
                    break;
            }

        }

        public static int GetUserInputBetweenInt(int minInput, int maxInput)
        {
            int variableToCheck = minInput - 1;

            while (!(variableToCheck >= minInput && variableToCheck <= maxInput))
            {
                if (Int32.TryParse(Console.ReadLine(), out int result))
                {
                    variableToCheck = result;
                    break;
                }
                else
                {
                    continue;
                }
            }

            return variableToCheck;
        }

        public static string GetUserProductChoice(Product product)
        {
            string name;
            var index = 1;
            Console.WriteLine("\nvad vill du köpa?");
            //skriv ut alla produkttyper i productList, med rätt format
            foreach (string i in product.productList())
            {
                Console.WriteLine(index + ": " + i);
                index ++;
            }

            name = product.productList()[GetUserInputBetweenInt(1, index) - 1];
            return name;
        }
        public static void CustomerCheckout(Customer customer)
        {
            Console.WriteLine();
            Console.WriteLine("din order är:");

            //skriv ut namnet på alla produkter som användaren köpt
            foreach (Product product in customer.ProductList)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
