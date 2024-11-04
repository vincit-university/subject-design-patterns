namespace FaculdadeVincit.DesignPatterns.StrategyPattern;

public class SacolaDeCompras
{
    public IPagamentoStrategy? Pagamento { get; set; }

    public void RealizarPagamento(double valor)
    {
        if (Pagamento == null)
        {
            Console.WriteLine("Método de Pagamento ainda não informado!");
            return;
        }

        Pagamento.Pagar(valor);
    }
}
