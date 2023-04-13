namespace Ejercicio._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = new DateTime();
            Console.WriteLine("Introduzca fecha ():");
            string dateString = Console.ReadLine();
            DateTime userDate = DateTime.Parse(dateString);
        }
    }
}