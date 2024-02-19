using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o valor original (ex: R$ 6.800,00): ");
        string valorOriginal = Console.ReadLine();

        Console.Write("Informe o desconto (ex: 30%): ");
        string desconto = Console.ReadLine();

        string resultado = Calculadora.FormatarValorComDesconto(valorOriginal, desconto);

        Console.WriteLine($"O valor com desconto é: {resultado}");
        Console.ReadLine();
    }
}
