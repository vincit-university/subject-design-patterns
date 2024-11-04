public class PagamentoPix implements IPagamentoStrategy {

    @Override
    public void pagar(double valor) {
        double desconto = valor * .10;
        double valorComDesconto = valor - desconto;
        System.out.println("Pagamento de R$ " + valorComDesconto + " realizado com sucesso!");
        System.out.println("Desconto por pagamento à vista: R$ " + desconto);
    }

}
