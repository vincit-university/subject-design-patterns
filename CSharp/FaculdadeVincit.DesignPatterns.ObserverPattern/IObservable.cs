namespace FaculdadeVincit.DesignPatterns.ObserverPattern;

public interface IObservable<TValue>
{
    void Update(TValue valor);
}
