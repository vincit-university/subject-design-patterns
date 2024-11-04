namespace FaculdadeVincit.DesignPatterns.StrategyPattern;

public class PagamentoPix : IPagamentoStrategy
{
    public void Pagar(double valor)
    {
        var desconto = valor * .10;
        var valorComDesconto = valor - desconto;
        Console.WriteLine($"Pagamewnto de R$ {valorComDesconto} realizado com Pix!");
        Console.WriteLine($"Desconto por pgto. à vista: R$ {desconto}");
    }

}
