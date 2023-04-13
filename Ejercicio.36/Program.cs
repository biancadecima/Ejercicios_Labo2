using System;

namespace Ejercicio._36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> numList = new List<int>();
            Random random= new Random();
            for(int i = 0; i < 20; i++)
            {
                numList.Add(random.Next(-100, 100));
            }
            foreach(int num in numList)
            {
                Console.WriteLine(num);
            }
            
            Console.WriteLine("--------------------");
            numList.Sort((x, y) => // recibe dos nums de la lista(x e y) y realiza la comparacion
            {
                return x.CompareTo(y);// creciente
            });
            foreach (int num in numList)
            {
                if (num < 0)
                    Console.WriteLine(num);
            }

            Console.WriteLine("--------------------");
            numList.Sort((x, y) =>
            {
                return y.CompareTo(x);// decreciente
            });
            foreach (int num in numList)
            {
                if(num > 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}