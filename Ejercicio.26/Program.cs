using ClassLibrary1;

namespace Ejercicio._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adder newAdder = new Adder(2);
            Adder adder2 = new Adder();
            Console.WriteLine(newAdder.ToString());
            Console.WriteLine(adder2.ToString());

            int test = newAdder.Add(4);
            Console.WriteLine("test int = {0}", test);
            long testLong = newAdder.Add(90, 64);
            Console.WriteLine("test long = {0}", testLong);
            string concat = newAdder.Add("con", "cat");
            Console.WriteLine(concat);

            var num = (int)adder2;
            Console.WriteLine("test explicit conversor = {0}", num);
            long sum = newAdder + adder2;
            Console.WriteLine("test add operator = {0}", sum);
            if(newAdder | adder2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}