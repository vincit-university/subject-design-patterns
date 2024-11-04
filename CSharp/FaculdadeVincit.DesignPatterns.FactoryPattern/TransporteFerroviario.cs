namespace FaculdadeVincit.DesignPatterns.FactoryPattern;

public class TransporteFerroviario : ITransporte
{
    public void Entregar()
    {
        System.Console.WriteLine("Entregando por ferrovia!");
    }

}
