using System;

public class Calculadora
{
    public int CalcularDiferencaData(string dataInicial, string dataFinal)
    {
        DateTime inicial = ConverterDateTime(dataInicial);
        DateTime final = ConverterDateTime(dataFinal);

        return CalcularDiferenca(inicial, final);
    }

    private DateTime ConverterDateTime(string data)
    {
        return DateTime.ParseExact(data, "ddMMyyyy", null);
    }

    private int CalcularDiferenca(DateTime inicio, DateTime fim)
    {
        return (int)(fim - inicio).TotalDays;
    }
}
