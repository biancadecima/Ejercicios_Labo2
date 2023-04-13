using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Shelf
    {
        private Product[] products;
        private int shelfLocation;

        private Shelf(int capacity)
        {
            products = new Product[capacity];
        }

        public Shelf(int capacity, int shelfLocation) : this(capacity)
        {
            products = new Product[capacity];
            this.shelfLocation = shelfLocation;
        }

        public Product[] GetProducts()
        {
            return this.products;
        }

        public static string ShowShelf(Shelf s)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto : ");
            foreach(Product p in s.GetProducts())
            {
                Product.ShowProduct(p);
            }
            sb.AppendLine($"Ubicaión de Estante : {s.shelfLocation}");
            return sb.ToString();
        }

        public static bool operator ==(Shelf s, Product p)
        {
            return s.products.Contains(p);
        }

        public static bool operator !=(Shelf s, Product p)
        {
            return!(s == p);
        }

        public static bool operator +(Shelf s, Product p)
        {
            if(s != p)
            {
                for (int i = 0; i < s.products.Length; i++)
                {
                    if (s.products[i] is null)
                    {
                        s.products[i] = p;
                        return true;
                    }
                }
            }    
            return false;
        }

        public static Shelf operator -(Shelf s, Product p)
        {
            for (int i = 0; i < s.products.Length; i++)
            {
                if (s.products[i] == p)
                {
                    s.products[i] = null;
                    break;
                }
            }
            return s;
        }
    }
}
