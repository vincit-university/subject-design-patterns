public class ContadorSingleton {
    private int valor = 0;
    private static ContadorSingleton instance;

    public static ContadorSingleton getInstance() {
        if (instance == null) {
            instance = new ContadorSingleton();
        }
        
        return instance;
    }

    public int getValor() {
        return valor;
    }


    public ContadorSingleton() {
        super();
    }

    public void incrementar() {
        valor++;
    }
}
