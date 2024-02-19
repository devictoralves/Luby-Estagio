using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var vetor = new string[] {
            "John Doe",
            "Jane Doe",
            "Alice Jones",
            "Bobby Louis",
            "Lisa Romero"
        };

        Console.Write("Digite o valor que você deseja buscar: ");
        string valorBusca = Console.ReadLine();

        var buscador = new Buscador(vetor);
        var resultado = buscador.Buscar(valorBusca);

        Console.WriteLine("\nResultados da busca:");
        foreach (var item in resultado)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}