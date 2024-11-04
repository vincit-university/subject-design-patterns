public class App {
    public static void main(String[] args) throws Exception {
        LojaFacade loja = new LojaFacade();

        loja.fazerPedido("Laptop", 2999.90);
        loja.fazerPedido("Smartphone", 1999.90);
        loja.fazerPedido("Jogo de Mesa com 4 Cadeiras", 799.90);
    }
}
