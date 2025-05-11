using System;
using System.Collections.Generic;
using System.Linq;

public class Filial 
{
    public string Estado { get; set; }
    public double Faturamento { get; set; }
    public double Percentual { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        var sp = new Filial { Estado = "SP", Faturamento = 67836.43 };
        var rj = new Filial { Estado = "RJ", Faturamento = 36678.66 };
        var mg = new Filial { Estado = "MG", Faturamento = 29229.88 };
        var es = new Filial { Estado = "ES", Faturamento = 27165.48 };
        var outros = new Filial { Estado = "Outros", Faturamento = 19849.53 };
        var dados = new List<Filial> { sp, rj, mg, es, outros };
        
        double totalFaturamento = dados.Sum(f => f.Faturamento);
        foreach (var filial in dados)
        {
            filial.Percentual = (filial.Faturamento / totalFaturamento) * 100;
        }

        foreach (var filial in dados)
        {
            Console.WriteLine($"Estado: {filial.Estado}, Faturamento: {filial.Faturamento}, Percentual: {filial.Percentual:F2}%");
        }
    }
}