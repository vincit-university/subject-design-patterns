namespace FaculdadeVincit.DesignPatterns.FacadePattern;

public class LojaFacade
{
    private readonly ProcessadorDePedidos _processadorDePedidos;
    private readonly SistemaDePagamentos _sistemaDePagamentos;
    private readonly SistemaDeEnvio _sistemaDeEnvio;

    public LojaFacade()
    {
        _processadorDePedidos = new ProcessadorDePedidos();
        _sistemaDePagamentos = new SistemaDePagamentos();
        _sistemaDeEnvio = new SistemaDeEnvio();
    }

    public void FazerPedido(string item, decimal valor)
    {
        _processadorDePedidos.CriarPedido(item);
        _sistemaDePagamentos.ProcessarPagamento(valor);
        _sistemaDeEnvio.EnviarPedido(item);

        System.Console.WriteLine("Pedido foi realizado com sucesso!");
    }

}
