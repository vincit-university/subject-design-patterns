namespace FaculdadeVincit.DesignPatterns.FacadePattern;

public class SistemaDePagamentos
{
    public void ProcessarPagamento(decimal valor)
    {
        System.Console.WriteLine($"Pagamento de valor R${valor} processado com sucesso!");
    }
}
