namespace FaculdadeVincit.DesignPatterns.ObserverPattern;

public class DisplayCelsiusObservable : IObservable<double>
{
    public void Update(double valor)
    {
        Console.WriteLine($"Temperatura em Célsius: {valor} ºC!");
    }

}
