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

        public static int Cookie(int cookieQuant)
        {
            cookieTotal = Math.ceil((cookieQuant / 2) * )
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

        public static int Bread(int breadQuant)
        {
            breadTotal = Math.ceil(breadQuant / 2) * 5;
            return breadTotal;
        }

    }

}