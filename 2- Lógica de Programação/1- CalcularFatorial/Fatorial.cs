using System;

namespace MyApp
{
    internal class Fatorial
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número para calcular o FATORIAL: ");
            int n = int.Parse(Console.ReadLine());

            long fatorial = CalculadoraFatorial.Calcular(n);

            Console.WriteLine("\nO fatorial de {0} é {1}.", n, fatorial);
            Console.ReadLine();
        }
    }
}
