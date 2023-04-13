using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    public class Euro
    {
        private double quantity;
        private static double priceInDollar;

        static Euro()
        {
            double defaultQuote = 1 / 1.17;
            priceInDollar = defaultQuote;
        }

        public Euro(double quantity)
        {
            this.quantity = quantity;
        }

        public Euro(double quantity, double price) : this(quantity)
        {
            priceInDollar = price;
        }

        public static double GetPriceInDollar() { return priceInDollar; }
        public double GetQuantity() { return this.quantity; }

        public static explicit operator Dollar(Euro e)
        {
            return new Dollar(e.quantity / priceInDollar);
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dollar)e);
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        public static bool operator ==(Euro a, Euro b)
        {
            return a.quantity == b.quantity;
        }

        public static bool operator ==(Euro e, Dollar d)
        {
            return e.quantity == (Euro)d.GetQuantity();
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e.quantity == (Euro)p.GetQuantity();
        }

        public static bool operator !=(Euro a, Euro b)
        {
            return !(a == b);
        }

        public static bool operator !=(Euro e, Dollar d)
        {
            return !(d == e);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static Euro operator +(Euro e, Dollar d)
        {
            return new Euro(e.quantity + ((Euro)d).quantity);
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.quantity + ((Euro)p).quantity);
        }

        public static Euro operator -(Euro e, Dollar d)
        {
            return new Euro(e.quantity - ((Euro)d).quantity);
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.quantity - ((Euro)p).quantity);
        }

    }
}
