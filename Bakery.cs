using System;

namespace Bakery
{

    public class Cookie
    {
        public int CookieQuant { get; set; }
        public int CookieTotal { get; set; }

        public Cookie (int cookieQuant, int cookieTotal)
        {
        CookieQuant = cookieQuant;
        CookieTotal = cookieTotal;
        }

        public static int CookieCost(int cookieQuant, int cookieTotal)
        {
            cookieTotal = Math.ceiling((cookieQuant / 3) * 5);
            return cookieTotal;
        }

    }


    public class Bread
    {
        public int BreadQuant { get; set; }
        public int BreadTotal { get; set; }

        public Bread(int breadQuant, int breadTotal)
        {
            BreadQuant = breadQuant;
            BreadTotal = breadTotal;
        }

        public static int BreadCost(int breadQuant, int breadTotal)
        {
            breadTotal = Math.ceiling(breadQuant / 2) * 5;
            return breadTotal;
        }

    }

}