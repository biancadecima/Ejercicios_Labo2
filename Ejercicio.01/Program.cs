using System.ComponentModel.DataAnnotations;

namespace Ejercicio._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int accumulator = 0;
            int counter = 0;
            int flag = 0;
            int min = 0;
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                Validate.ValidateNumber(out num);
                accumulator += num;
                counter++;
                if (flag == 0)
                {
                    min = num;
                    max = num;
                    flag = 1;
                }
                else
                {
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < max)
                    {
                        max = num;
                    }
                }
            }
            
            Console.WriteLine("El promedio de numeros ingresados es {0}", Math.Average(accumulator, counter));
            Console.WriteLine("El menor de numeros ingresados es {0}", min);
            Console.WriteLine("El mayor de numeros ingresados es {0}", max);
        }
    }
}