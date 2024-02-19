using System;

class Program
{
    static void Main()
    {

        Console.Write("Digite um TEXTO e descubra quantas vogais tem: ");
        string texto = Console.ReadLine();

        CalcularVogais calculadoraVogais = new CalcularVogais();

        int quantidadeVogais = calculadoraVogais.ContarVogais(texto);

        Console.WriteLine($"Quantidade de Vogais: {quantidadeVogais}");
        Console.ReadLine();
    }
}
