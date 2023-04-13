using System.Runtime.CompilerServices;
using System.Text;

namespace ClassLibrary1
{
    public class Adder
    {
        private int amountOfSums;

       
        public Adder(int amountOfSums)
        {
            this.amountOfSums = amountOfSums;
        }

        public Adder() : this(0) // sobrecarga de contructor
        {}

        public int Add(int amountOfSums)
        {
            return amountOfSums+ 1;
        }

        public long Add(long a, long b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            return String.Concat(a, b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.amountOfSums}");

            return sb.ToString();
        }

        public static explicit operator int (Adder adder)
        {
            return adder.amountOfSums;
        }

        public static long operator +(Adder a, Adder b)
        {
            return a.amountOfSums + b.amountOfSums;
        }

        public static bool operator |(Adder a, Adder b)
        {
            if(a.amountOfSums == b.amountOfSums)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}