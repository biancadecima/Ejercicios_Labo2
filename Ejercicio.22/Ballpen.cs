using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._22
{
    internal class Ballpen
    {
        private const short maxQuantity = 100;
        private ConsoleColor color;
        private short ink;

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetInk()
        {
            return ink;
        }

        private void SetInk(short ink)
        {
            if (ink >= 0 && ink <= maxQuantity)
            {
                this.ink = ink;
            }
        }

        private void Recharge()
        {
            SetInk(maxQuantity);
        }
    }
}
