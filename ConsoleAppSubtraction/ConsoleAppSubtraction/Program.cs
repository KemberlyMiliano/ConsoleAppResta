using System;
namespace ConsoleAppSubtraction
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("________________________");
            Console.WriteLine("         Resta");
            Console.WriteLine("________________________");
            Console.WriteLine("Inserte el primer numero:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserte el primer numero:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Subtraction subtraction = new Subtraction(number1, number2);
            Console.WriteLine("Resultado:");
            Console.WriteLine(subtraction.Result);

        }
    }
}
