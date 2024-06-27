namespace TheCSharpPlayground.TestesTecnicos;

public class AnaliseRelatorio
{
    Relatorio AnalisaFaturamento(decimal[] faturamentosDiarios)
    {
        var faturamentosFiltrados = faturamentosDiarios.Where(valor => valor > 0);

        Relatorio relatorio = new Relatorio()
        {
            menorFaturamento = faturamentosFiltrados.Min(),
            maiorFaturamento = faturamentosFiltrados.Max(),
            diasAcimaDaMedia = faturamentosFiltrados.Count(valor => valor > faturamentosFiltrados.Average())
        };

        return relatorio;
    }
}

public class Relatorio
{
    public decimal menorFaturamento { get; set; }
    public decimal maiorFaturamento { get; set; }
    public int diasAcimaDaMedia { get; set; }

    public void EscreverRelatorio()
    {
        Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}

