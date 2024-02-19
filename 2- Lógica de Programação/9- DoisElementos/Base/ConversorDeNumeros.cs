using System.Linq;

public class ConversorDeNumeros
{
    public static int[][] TransformarEmMatriz(string str)
    {
        int[] numeros = str.Split(',').Select(int.Parse).ToArray();
        int[][] matriz = new int[(numeros.Length + 1) / 2][];

        for (int i = 0; i < numeros.Length; i += 2)
        {
            matriz[i / 2] = i + 1 < numeros.Length ? new int[] { numeros[i], numeros[i + 1] } : new int[] { numeros[i] };
        }

        return matriz;
    }
}
