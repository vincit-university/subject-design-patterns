public class PagamentoCheque implements IPagamentoStrategy {

    @Override
    public void pagar(double valor) {
        System.out.println("Pagamento de R$ " + valor + " realizado com sucesso");
    }

}
