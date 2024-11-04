public class SacolaDeCompras {
    private IPagamentoStrategy pagamento;

    public IPagamentoStrategy getPagamento() {
        return pagamento;
    }

    public void setPagamento(IPagamentoStrategy pagamento) {
        this.pagamento = pagamento;
    }

    public void realizarPagamento(double valor) {
        if (pagamento == null) {
            System.out.println("Forma de Pagamento não definida!");
            return;
        }

        pagamento.pagar(valor);
    }
}
