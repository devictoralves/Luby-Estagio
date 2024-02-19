using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma sequência de números separados por vírgula: ");
        var entrada = Console.ReadLine();

        var numeros = Calculadora.LerNumeros(entrada);
        var numerosPares = Calculadora.ObterNumerosPares(numeros);

        Console.WriteLine("Números pares: " + string.Join(", ", numerosPares));
        Console.ReadLine();
    }
}
