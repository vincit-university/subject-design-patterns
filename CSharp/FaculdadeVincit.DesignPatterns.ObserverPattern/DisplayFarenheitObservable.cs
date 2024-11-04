namespace FaculdadeVincit.DesignPatterns.ObserverPattern;

public class DisplayFarenheitObservable : IObservable<double>
{
    public void Update(double valor)
    {
        var fareinheit = (valor * 9 / 5) + 32;
        Console.WriteLine($"Temperatura em Farenheit: {fareinheit} ºF!");
    }

}
