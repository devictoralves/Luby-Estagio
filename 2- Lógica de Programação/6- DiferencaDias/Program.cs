using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a data de início (formato ddMMyyyy): ");
        string dataInicio = Console.ReadLine();

        Console.Write("Digite a data de fim (formato ddMMyyyy): ");
        string dataFim = Console.ReadLine();

        Calculadora calculadora = new Calculadora();

        try
        {
            int resposta = calculadora.CalcularDiferencaData(dataInicio, dataFim);
            Console.Write($"\nA diferença em dias é: {resposta}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        Console.ReadLine(); 
    }
}