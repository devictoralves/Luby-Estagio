using System.Globalization;

public class Calculadora
{
    public static string FormatarValorComDesconto(string valorString, string descontoString)
    {
        double valorOriginal = double.Parse(
            valorString.Replace(".", "").Replace(",", ".").Replace("R$", ""),
            CultureInfo.InvariantCulture);

        double descontoPercent = double.Parse(
            descontoString.Replace("%", ""),
            CultureInfo.InvariantCulture) / 100;

        double resultado = valorOriginal * (1 - descontoPercent);

        return $"R$ {resultado.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"))}";
    }
}
