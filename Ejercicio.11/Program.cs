using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            char continuar;
            int numInput;
            do
            {
                Console.WriteLine("Ingrese un número:");
                Validador.ValidarNumero(out numInput);
                acumulador += numInput;
                Console.WriteLine("Desea Continuar?");
                continuar = char.Parse(Console.ReadLine());

            } while (Validador.ValidarRespuesta(continuar));
            Console.WriteLine("La suma de los numeros ingresados es: {0}", acumulador);
        }
    }
}