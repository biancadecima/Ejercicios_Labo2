using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._13
{
    internal class Calculator
    {
        static public int Calculate(int a, int b, char c)
        {
            int result = 0;
            switch(c)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': 
                    if(Validate(b))
                    {
                        result = a / b;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No se puede multiplicar por 0");
                        break;
                    } 
            }
            return result;

        }

        static private bool Validate(int b)
        {
            return b != 0;
        }
    }
}
