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
            while (menuChoice != 2) {
                while (true) {
                    Console.WriteLine("vad vill du göra, " +  customer.Name + "?\n" +
                                   "1: köp en produkt\n" +
                                   "2: checka ut");
                    if (Int32.TryParse(Console.ReadLine(), out int result)) //låt användaren skriva något
                    {
                        menuChoice = result; //om användaren skrev in en int, låt ett variabel få det värdet
                        if (menuChoice == 1 || menuChoice == 2) //kolla om menuChoice är ett av de giltiva värdena
                        {
                            break; //om menuChoice är giltigt, hoppa ut ur loopen
                        }
                        else
                        {
                            continue; //om menuChoice inte var giltigt, kör om loopen
                        }
                    }
                    else
                    {
                        continue; //om användaren inte skrev in en int, kör om loopen
                    }
                }

                switch (menuChoice)
                {
                    case 1: AddProduct(customer); break;
                    case 2: CustomerCheckout(customer); break;
                }
            }
        }

        public static void AddProduct(Customer customer)
        {
            String productName;
            int productPrice;
            Console.WriteLine("vad vill du köpa?");
            productName = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("hur mycket kostar den?");
                if (Int32.TryParse(Console.ReadLine(), out int result))
                {
                    productPrice = result;
                    break;
                } else
                {
                    continue;
                }
            }
            Product product = new Product { Name = productName, Price = productPrice };
            customer.ProductList.Add(product);
        }

        public static void CustomerCheckout(Customer customer)
        {
            Console.WriteLine();
            var totalPrice = 0;
            Console.WriteLine("din order är:");
            foreach (Product product in customer.ProductList) //skriv ut namnet på alla produkter som användaren köpt, och dess pris
            {
                Console.WriteLine(product.Name + "\t" + product.Price + "kr");
                totalPrice += product.Price;
            }
            Console.WriteLine("totalpris:\t" + totalPrice + "kr");
        }
    }
}
