namespace FaculdadeVincit.DesignPatterns.FactoryPattern;

public class TransporteRodoviario : ITransporte
{
    public void Entregar()
    {
        System.Console.WriteLine("Entregando por rodovia.");
    }

}
