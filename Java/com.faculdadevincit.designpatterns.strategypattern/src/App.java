public class App {
    public static void main(String[] args) throws Exception {
        SacolaDeCompras sacola = new SacolaDeCompras();

        sacola.setPagamento(new PagamentoCheque());
        sacola.realizarPagamento(1500);
        System.out.println();

        sacola.setPagamento(new PagamentoComCartaoDeCredito());
        sacola.realizarPagamento(1300);
        System.out.println();

        sacola.setPagamento(new PagamentoPix());
        sacola.realizarPagamento(1100);
    }
}
