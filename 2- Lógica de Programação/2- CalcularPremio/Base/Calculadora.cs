using System.Collections.Generic;

public class CalculadoraPremio
{
    public double CalcularPremio(double valor, string tipo, double? multProprio)
    {
        Dictionary<string, double> fatores = new Dictionary<string, double>
        {
            { "basic", 1.0 },
            { "vip", 1.2 },
            { "premium", 1.5 },
            { "deluxe", 1.8 },
            { "special", 2.0 }
        };

        double multTotal = Math.Max(fatores.GetValueOrDefault(tipo), multProprio ?? 0);

        double premioTotal = (valor * multTotal);

        return premioTotal > 0 ? premioTotal : 0;
    }
}
