using System;
using System.Collections.Generic;


namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Amy's Baking Co! Today, we have fresh sourdough loaves for $6 and our pastery of the day for $2. Would you like to buy anything? Y/N");
            string PurchaseYN = Console.ReadLine();
            if (PurchaseYN == "Y" || PurchaseYN == "y")
            {
                Console.WriteLine("How many loaves of sourdough would you like?");
                int quantityLoaves = int.Parse(Console.ReadLine());
                Console.WriteLine("How many pasteries would you like?");
                int quantityPasteries = int.Parse(Console.ReadLine());            
            }

            else 
            {
                Console.WriteLine("Thanks for stopping by. I hope you have a great rest of your day!");
            }
        }

       
    }
}