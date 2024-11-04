namespace FaculdadeVincit.DesignPatterns.StrategyPattern;

public class PagamentoComCartaoDeCredito : IPagamentoStrategy
{
    public void Pagar(double valor)
    {
        var acrescimo = valor * .10;
        var valorComAcrescimo = valor + acrescimo;
        Console.WriteLine($"Pagamento de R$ {valorComAcrescimo} realizado com Cartão!");
        System.Console.WriteLine($"Acréscimo de R$ {acrescimo} no Cartão");
    }

}
