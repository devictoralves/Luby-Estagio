using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("VALOR DO PRÊMIO: ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("SELECIONE UMA OPÇÃO: (basic, vip, premium, deluxe ou special): ");
        string tipo = Console.ReadLine().ToLower();

        Console.Write("Insira o multiplicador personalizado: ");
        double multProprio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        CalculadoraPremio calculadora = new CalculadoraPremio();

        Console.Write("\nValor Total: $ " + calculadora.CalcularPremio(valor, tipo, multProprio).ToString("F2", CultureInfo.InvariantCulture));
    }
}
