using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            var arr = new[]
                       {
                    @" _    _      _                          ",
                    @"| |  | |    | |                         ",
                    @"| |  | | ___| | ___ ___  _ __ ___   ___ ",
                    @"| |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \",
                    @"\  /\  /  __/ | (_| (_) | | | | | |  __/",
                    @" \/  \/ \___|_|\___\___/|_| |_| |_|\___|",

            };
            Console.WriteLine("\n\n");
            foreach (string line in arr)
                Console.WriteLine(line); 
                Console.WriteLine("...to Amy's Baking Co! Today, we have fresh sourdough loaves for $5 (Buy 2, get 1 free) and our cookie of the day for $2/each or 3 for $5. Would you like to buy anything? Y/N");
            string PurchaseYN = Console.ReadLine();
            if (PurchaseYN == "Y" || PurchaseYN == "y")
            {
                Console.WriteLine("How many loaves of sourdough would you like?");
                int breadQuant = int.Parse(Console.ReadLine());
                Console.WriteLine("How many cookies would you like?");
                int cookieQuant = int.Parse(Console.ReadLine());
                int cookieTotal = 0;
                int breadTotal = 0;
                Cookie cookie = new Cookie(cookieQuant, cookieTotal);
                Bread bread = new Bread(breadQuant, breadTotal);
                int total = (Cookie.CookieCost(cookieQuant, cookieTotal)) + (Bread.BreadCost(breadQuant, breadTotal));
                Console.WriteLine("Your total is $" + total + ". Would you like anything else? Y/N");
                string PurchaseMoreYN = Console.ReadLine();
                if (PurchaseMoreYN == "Y" || PurchaseMoreYN == "y")
                {
                    Console.WriteLine("How many more loaves would you like?");
                    int newBreadQuant = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many more cookies would you like?");
                    int newCookieQuant = int.Parse(Console.ReadLine());
                    int finalBreadQuant = newBreadQuant + breadQuant;
                    int finalCookieQuant = newCookieQuant + cookieQuant;
                    int newTotal = (Cookie.CookieCost(finalCookieQuant, cookieTotal)) + (Bread.BreadCost(finalBreadQuant, breadTotal));
                    Console.WriteLine("Your new total is $" + newTotal + ".");

                }
                else
                {
                    Console.WriteLine("Ok, then give me $" + total + ".");
                }

                    
            } 
            else 
            {
                Console.WriteLine("No problem. Thanks for stopping by. I hope you have a great rest of your day!");
            }
        }
    }
}