using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._11
{
    internal class Validador
    {
        static public bool ValidarNumero(out int num)
        {
            return int.TryParse(Console.ReadLine(), out num);
        }
        static public bool ValidarRespuesta(char respuesta)
        {
            if(respuesta == 's')
                return true;
            else
                return false;
        }
    }
}
