namespace FaculdadeVincit.DesignPatterns.FacadePattern;

public class ProcessadorDePedidos
{
    public void CriarPedido(string item)
    {
        System.Console.WriteLine($"Pedido para o item '{item}' criado!");
    }
}
