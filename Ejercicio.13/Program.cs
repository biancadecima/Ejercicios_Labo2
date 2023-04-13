namespace Ejercicio._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            int result;

            Console.WriteLine("Ingrese el primer operando:");
            Validador.ValidarNumero(out num1);
            Console.WriteLine("Ingrese el segundo operando:");
            Validador.ValidarNumero(out num2);
            Console.WriteLine("Ingrese la operación:");
            op = char.Parse(Console.ReadLine());

            result = Calculator.Calculate(num1, num2, op);
            Console.WriteLine("Resultado de la operación: {0}", result);
        }
    }
}