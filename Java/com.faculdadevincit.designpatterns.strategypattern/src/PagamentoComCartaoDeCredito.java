public class PagamentoComCartaoDeCredito implements IPagamentoStrategy {

    @Override
    public void pagar(double valor) {
        double acrescimo = valor * .10;
        double valorComAcrescimo = valor + acrescimo;
        System.out.println("Pagamento de R$ " + valorComAcrescimo + " realizado com sucesso!");
        System.out.println("Acréscimo de R$ " + acrescimo + " por pagamento no Cartão!");
    }

}
