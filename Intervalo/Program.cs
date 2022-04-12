using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // variavel 
            double N;

            //Entrada
            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Processamento / Saida
            if (N < 0.0 || N > 100.0)
                Console.WriteLine("Fora de Intervalo");
            else if (N <= 25.0)
                Console.WriteLine("Intervalo (0,25)");
            else if(N <= 50.0)
                Console.WriteLine("Intervalo (25,50)");
            else if(N <= 75.0)
                Console.WriteLine("Intervalo (50,75)");
            else
                Console.WriteLine("intervalo (75,100)");
        }
    }
}