namespace FaculdadeVincit.DesignPatterns.SingletonPattern;

public class ContadorSingleton
{
    private static ContadorSingleton? instance;
    public int Valor { get; private set; }

    public static ContadorSingleton Instance { 
        get => instance ??= new ContadorSingleton(); 
    }

    public void Incrementar() => Valor++;
}
