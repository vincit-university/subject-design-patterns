namespace FaculdadeVincit.DesignPatterns.StrategyPattern;

public class PagamentoCheque : IPagamentoStrategy
{
    public void Pagar(double valor)
    {
        Console.WriteLine($"Pagamento de R$ {valor} realizado com sucesso!");
    }
}
