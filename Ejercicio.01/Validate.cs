using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._01
{
    internal class Validate
    {
        static public bool ValidateNumber(out int num)
        {
            return int.TryParse(Console.ReadLine(), out num);
        }
    }
}
