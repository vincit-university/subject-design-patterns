namespace FaculdadeVincit.DesignPatterns.FacadePattern;

public class SistemaDeEnvio
{
    public void EnviarPedido(string item)
    {
        System.Console.WriteLine($"Pedido do item '{item}' enviado com sucesso!");
    }
}
