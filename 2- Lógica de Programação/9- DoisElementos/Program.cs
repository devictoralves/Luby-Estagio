using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite seus números separados por virgula (Ex 1,2,3,4,5,6): ");
        string numeros = Console.ReadLine();
        int[][] resultado = ConversorDeNumeros.TransformarEmMatriz(numeros);

        foreach (var par in resultado)
        {
            Console.WriteLine(string.Join(", ", par));
        }
        Console.ReadLine();
    }
}
