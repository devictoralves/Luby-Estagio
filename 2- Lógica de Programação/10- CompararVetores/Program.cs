using System;
using System.Linq;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira os elementos do primeiro vetor, separados por espaço:");
        int[] vetor1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Insira os elementos do segundo vetor, separados por espaço:");
        int[] vetor2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var elementosFaltantes = vetor1.Except(vetor2).Union(vetor2.Except(vetor1)).ToArray();

        Console.WriteLine("Elementos faltantes: " + string.Join(", ", elementosFaltantes));
        Console.ReadLine();

    }
}
