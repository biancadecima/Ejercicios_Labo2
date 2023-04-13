using System.ComponentModel.DataAnnotations;
using System;

namespace Ejercicio._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero:");
            Validate.ValidateNumber(out num);
            if (Validate.IsNotZero(num))
            {
                Console.WriteLine("El cuadrado del numero es: {0}", Math.Squared(num));
                Console.WriteLine("El cubo del numero es: {0}", Math.Cube(num));
            }
            else
            {
                Console.WriteLine("Error, Reingresar...");
            }
        }
    }
}