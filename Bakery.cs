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

        public static int CookieCost(int cookieQuant, double cookieTotal)
        {
            cookieTotal = Math.Ceiling(((double)cookieQuant / 3) * 5);
            // cookieTotal = ((cookieQuant / 3) * 5);

            return (int)cookieTotal;
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

        public static int BreadCost(int breadQuant, double breadTotal)
        {
            breadTotal = Math.Ceiling((double)breadQuant / 1.5) * 5;
            // breadTotal = ((double)breadQuant / 2) * 5;

            return (int)breadTotal;
        }

    }

}