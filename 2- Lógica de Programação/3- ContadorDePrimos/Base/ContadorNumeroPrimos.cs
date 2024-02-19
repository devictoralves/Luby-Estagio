class ContadorNumeroPrimos
{
    public int ContarNumerosPrimos(int val)
    {
        int contador = 0;
        DescobridorPrimo descobridor = new DescobridorPrimo();

        for (int i = 2; i <= val; i++)
        {
            if (descobridor.Primo(i))
                contador++;
        }

        return contador;
    }
}
