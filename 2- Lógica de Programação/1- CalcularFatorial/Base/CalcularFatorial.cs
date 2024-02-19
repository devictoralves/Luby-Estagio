using System;

namespace MyApp
{
    internal class CalculadoraFatorial
    {
        public static long Calcular(int numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("O conceito de fatorial não é aplicável a números negativos ou números não inteiros.");
                return -1; 
            }

            if (numero == 0)
            {
                Console.WriteLine("Matematicamente, por convenção, o fatorial de zero é considerado 1.");
                return 1;
            }

            long resultado = 1;

            while (numero != 1)
            {
                resultado *= numero;
                numero--;
            }

            return resultado;
        }
    }
}
