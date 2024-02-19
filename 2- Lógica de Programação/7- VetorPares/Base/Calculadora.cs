using System;
using System.Linq;

public static class Calculadora
{
    public static int[] LerNumeros(string entrada)
    {
        return entrada.Split(',').Select(int.Parse).ToArray();
    }

    public static int[] ObterNumerosPares(int[] numeros)
    {
        return numeros.Where(num => num % 2 == 0).ToArray();
    }
}
