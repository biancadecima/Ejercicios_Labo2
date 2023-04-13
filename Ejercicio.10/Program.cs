using System.Drawing;

namespace Ejercicio._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;
            int promedio;
            int minimo = 0;
            int flag = 0;
            int maximo = 0;
            int numInput;
            do
            {
                Console.WriteLine("Ingrese un número:");
                //int numInput; = int.Parse(Console.ReadLine());
                Validador.ValidarNumero(out numInput);
                if(Validador.ValidarRango(numInput, -100, 100))
                {
                    Console.WriteLine("Valor aceptado");
                    acumulador += numInput;
                    if (flag == 0)
                    {
                        minimo = numInput;
                        maximo = numInput;
                        flag = 1;
                    }
                    else
                    {
                        if(numInput > maximo)
                        {
                            maximo = numInput;
                        }
                        if (numInput < minimo)
                        {
                            minimo = numInput;
                        }
                    }
                    contador++;
                }
                else
                {
                    Console.WriteLine("Valor fuera de rango. Reingrese...");
                }
                
            } while (contador < 10);
            promedio = acumulador / contador;
            Console.WriteLine("El promedio de numeros ingresados es {0}", promedio);
            Console.WriteLine("El menor de numeros ingresados es {0}", minimo);
            Console.WriteLine("El mayor de numeros ingresados es {0}", maximo);
        }
    }
}