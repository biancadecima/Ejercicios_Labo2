using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Text;

namespace Product
{
    public class Product
    {
        private string _barcode;
        private string _brand;
        private float _price;

        public string Brand { 
            get { return _brand; } 
            set { _brand = value; } 
        }

        public float Price { 
            get { return _price; } 
            set { _price = value; }
        }

        public Product(string barcode, string brand, float price)
        {
            _barcode = barcode;
            Brand = brand;
            Price = price;
        }

        public static explicit operator string(Product p) 
        {
            return p._barcode;
        }

        public static bool operator ==(Product p, string brand)
        {
            return (p._brand == brand);
        }

        public static bool operator ==(Product p1, Product p2)
        {
            return p1._barcode == p2._barcode && p1._brand == p2._brand;
        }

        public static bool operator !=(Product p, string brand)
        {
            return !(p != brand);
        }

        public static bool operator !=(Product p1, Product p2)
        {
            return!(p1 == p2);
        }

        public static string ShowProduct(Product p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Código de Barras : {p._barcode} - Marca: {p._brand} - Precio: {p._price}");
            return sb.ToString();
        }


    }
}