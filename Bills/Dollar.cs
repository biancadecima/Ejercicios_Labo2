using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    public class Dollar
    {
        private double quantity;
        private static double priceInDollar;
        
        static Dollar()
        {
            int defaultQuote = 1;
            priceInDollar = defaultQuote;
        }

        public Dollar(double quantity)
        {
            this.quantity = quantity;
        }

        public double GetQuantity()
        {
            return this.quantity;
        }

        public static double GetPrice()
        {
            return priceInDollar;
        }

        public static explicit operator Euro(Dollar d)
        {
            return new Euro(Euro.GetPriceInDollar() * d.quantity);
        }

        public static explicit operator Pesos(Dollar d)
        {
            return new Pesos(Pesos.GetPriceInDollar() * d.quantity);
        }

        public static implicit operator Dollar(double d)
        {
            return new Dollar(d);
        }

        public static bool operator ==(Dollar a, Dollar b)
        {
            return a.quantity == b.quantity;
        }

        public static bool operator ==(Dollar d, Euro e)
        {
            return d.quantity == (Dollar)e.GetQuantity();
        }

        public static bool operator ==(Dollar d, Pesos p)
        {
            return d.quantity == ((Dollar)p).GetQuantity();
        }

        public static bool operator !=(Dollar a, Dollar b)
        {
            return !(a == b);
        }

        public static bool operator !=(Dollar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dollar d, Pesos p)
        {
            return !(d == p);
        }

        public static Dollar operator +(Dollar d, Euro e)
        {
            return new Dollar(d.quantity + ((Dollar)e).quantity);
        }

        public static Dollar operator +(Dollar d, Pesos p)
        {
            return new Dollar(d.quantity + ((Dollar)p).quantity);
  
        }

        public static Dollar operator -(Dollar d, Euro e)
        {
            return new Dollar(d.quantity - ((Dollar)e).quantity);
        }

        public static Dollar operator -(Dollar d, Pesos p)
        {
            return new Dollar(d.quantity - ((Dollar)p).quantity);
        }

    }
}
