using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    public class Pesos
    {
        private double quantity;
        private static double priceInDollar;

        static Pesos()
        {
            double defaultQuote = 1 / 102.65;
            priceInDollar = defaultQuote;
        }

        public Pesos(double quantity)
        {
            this.quantity = quantity;
        }

        public Pesos(double quantity, double price) : this(quantity)
        {
            priceInDollar = price;
        }

        public static double GetPriceInDollar() { return priceInDollar; }
        public double GetQuantity() { return this.quantity; }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dollar)p);
        }

        public static explicit operator Dollar(Pesos p)
        {
            return new Dollar (p.quantity / GetPriceInDollar());
        }

        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }

        public static bool operator ==(Pesos a, Pesos b)
        {
            return a.quantity == b.quantity;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p.quantity == ((Pesos)e).quantity;
        }

        public static bool operator ==(Pesos p, Dollar d)
        {
            return p.quantity == ((Pesos)d).quantity;
        }

        public static bool operator !=(Pesos a, Pesos b)
        {
            return !(a == b);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Pesos p, Dollar d)
        {
            return !(d == p);
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.quantity + ((Pesos)e).quantity);
        }

        public static Pesos operator +(Dollar d, Pesos p)
        {
            return new Pesos(p.quantity + ((Pesos)d).quantity);

        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.quantity - ((Pesos)e).quantity);
        }

        public static Pesos operator -(Pesos p, Dollar d)
        {
            return new Pesos(p.quantity - ((Pesos)d).quantity);
        }
    }
}