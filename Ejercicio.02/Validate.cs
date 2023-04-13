using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._02
{
    internal class Validate
    {
        static public bool ValidateNumber(out int num)
        {
            return int.TryParse(Console.ReadLine(), out num);
        }
        static public bool IsNotZero(int num)
        {
            return num != 0;
        }
    }
}
