public class LojaFacade {
    private ProcessadorDePedidos processadorDePedidos;
    private SistemaDePagamentos sistemaDePagamentos;
    private SistemaDeEnvio sistemaDeEnvio;

    public LojaFacade() {
        processadorDePedidos = new ProcessadorDePedidos();
        sistemaDePagamentos = new SistemaDePagamentos();
        sistemaDeEnvio = new SistemaDeEnvio();
    }

    public void fazerPedido(String item, double valor) {
        processadorDePedidos.CriarPedido(item);
        sistemaDePagamentos.ProcessarPagamento(valor);
        sistemaDeEnvio.EnviarPedido(item);

        System.out.println("Pedido realizado com sucesso!");
    }
}
