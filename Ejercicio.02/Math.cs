using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._02
{
    internal class Math
    {
        static public float Average (int value, int total)
        {
            return value / total;
        }

        static public int Squared (int num)
        {
            return num * num;
        }

        static public int Cube (int num)
        {
            return num * num * num;
        }
    }
}
