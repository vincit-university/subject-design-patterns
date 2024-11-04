public class App {
    public static void main(String[] args) throws Exception {
        int valor;
        String mensagem;
        ContadorSingleton contador1, contador2, contador3;

        contador1 = ContadorSingleton.getInstance();
        contador2 = ContadorSingleton.getInstance();
        contador3 = ContadorSingleton.getInstance();

        contador1.incrementar();
        contador2.incrementar();
        contador3.incrementar();

        valor = contador1.getValor();
        mensagem = String.format("Contador 1: %d", valor);
        System.out.println(mensagem);

        valor = contador2.getValor();
        mensagem = String.format("Contador 2: %d", valor);
        System.out.println(mensagem);

        valor = contador3.getValor();
        mensagem = String.format("Contador 3: %d", valor);
        System.out.println(mensagem);
    }
}
