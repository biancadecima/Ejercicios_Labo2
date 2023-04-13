using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._10
{
    internal class Validador
    {
        static public bool ValidarNumero(out int num)
        {
            return int.TryParse(Console.ReadLine(), out num);
        }
        static public bool ValidarRango(int valor, int min, int max)
        { 
            return valor >= min && valor <= max; 
        }
    }
}
