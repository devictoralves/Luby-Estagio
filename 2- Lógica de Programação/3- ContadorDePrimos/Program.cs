using System;

class Program
{
    static void Main()
    {
        ContadorNumeroPrimos contador = new ContadorNumeroPrimos();

        Console.Write("Digite o número FINAL e descubra quantos números primos tem até ele: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = contador.ContarNumerosPrimos(n);
        Console.WriteLine($"Total de números primos: {resultado}");
        Console.ReadLine();
    }
}
