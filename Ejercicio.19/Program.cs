namespace Ejercicio._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta nuevaCuenta = new Cuenta("Particular", 20000);
            nuevaCuenta.ingresar(3000);
            nuevaCuenta.retirar(500);
            Console.WriteLine(nuevaCuenta.ToString());
            
        }
    }
}