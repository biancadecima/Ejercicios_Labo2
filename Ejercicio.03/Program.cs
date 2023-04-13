using System.Text;
namespace Ejercicio._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            int numInput = int.Parse(Console.ReadLine());
            //bool sePudo = int.TryParse(numIinput, out int resultado) vañida si se pudo parsear
            Console.WriteLine(ListarNumeroPrimo(numInput));
        }

        public static string ListarNumeroPrimo(int numero)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 2; i <= numero; i++)
            {
                // Manejar la logica de si i es primo
                if (EsPrimo(i))
                {
                    sb.Append($"{i}, ");
                }  
            }

            return sb.ToString();
        }

        public static bool EsPrimo(int numero)
        { 
            for(int i = 2; i < numero; i++)
            {
                if(numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}