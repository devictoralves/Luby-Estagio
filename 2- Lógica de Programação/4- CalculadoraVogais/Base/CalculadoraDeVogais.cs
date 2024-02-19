public class CalcularVogais
{
    public int ContarVogais(string texto)
    {
        char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
        int contadorVogais = 0;

        foreach (char letra in texto.ToLower())
        {
            if (VogalExisteNaLista(letra, vogais))
            {
                contadorVogais++;
            }
        }

        return contadorVogais;
    }

    private bool VogalExisteNaLista(char letra, char[] vogais)
    {
        foreach (char vogal in vogais)
        {
            if (vogal == letra)
            {
                return true;
            }
        }
        return false;
    }
}
