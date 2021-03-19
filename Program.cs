using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius;
            double Fahrenheit = 32;
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Digite seu Valor em Celsius: ");
            Celsius = double.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Fahrenheit = Celsius * 1.8 + 32;
            Console.WriteLine("Celsius para Fahrenheit = {0}", Fahrenheit);
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pressione ENTER para sair!");
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
