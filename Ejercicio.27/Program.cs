using Bills;

namespace Ejercicio._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dollar newDollar = new Dollar(10);
            Dollar newDollar2 = new Dollar(10);
            if(newDollar == newDollar2)
            {
                Console.WriteLine("Los dólares son la misma cantidad");
            }
            else
            {
                Console.WriteLine("Los dólares NO son la misma cantidad");
            }


            Euro newEuro = new Euro(5);
            Euro newEuro2 = (Euro)newDollar2;
            Console.WriteLine("Conversion dolar a euro: {0}", newDollar2.GetQuantity());

            Pesos newPeso = new Pesos(5);
            Pesos newPeso2 = new Pesos(10);
            
            
            Euro test = newEuro + newPeso;
            Console.WriteLine("Suma euro y peso en euro: {0}", test.GetQuantity());
            Pesos test2 = newPeso2 - newDollar;
            Console.WriteLine("Suma dolar y peso en peso: {0}", test2.GetQuantity());
            //Console.WriteLine("Hello, World!");
        }
    }
}