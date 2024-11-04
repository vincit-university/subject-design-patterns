namespace FaculdadeVincit.DesignPatterns.ObserverPattern;

public class EstacaoMeteorologica : Publisher<double>
{
    private double _temperatura = 0;
    public double Temperatura
    {
        get => _temperatura;
        set
        {
            _temperatura = value;
            NotifyObservables(_temperatura);
        }
    }
}
