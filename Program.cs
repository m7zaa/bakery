using System;
using System.Collections.Generic;


namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Amy's Baking Co! Today, we have fresh sourdough loaves for $5 (Buy 2, get 1 free) and our cookie of the day for $2/each or 3 for $5. Would you like to buy anything? Y/N");
            string PurchaseYN = Console.ReadLine();
            if (PurchaseYN == "Y" || PurchaseYN == "y")
            {
                Cookie cookie = new Cookie(cookieQuant, cookieTotal);
                Bread bread = new Bread(breadQuant, breadTotal);
                Console.WriteLine("How many loaves of sourdough would you like?");
                int breadQuant = int.Parse(Console.ReadLine());
                Console.WriteLine("How many cookies would you like?");
                int cookieQuant = int.Parse(Console.ReadLine());
                int total = (cookie.CookieCost(cookieQuant)) + (bread.BreadCost(breadQuant));
                Console.WriteLine("Your total is $" + total);
            }
            else 
            {
                Console.WriteLine("No problem. Thanks for stopping by. I hope you have a great rest of your day!");
            }
        }

       
    }
}