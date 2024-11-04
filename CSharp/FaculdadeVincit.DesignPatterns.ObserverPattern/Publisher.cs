namespace FaculdadeVincit.DesignPatterns.ObserverPattern;

public abstract class Publisher<TValue>
{
    protected List<IObservable<TValue>> Observables { get; private set; }

    public Publisher()
    {
        Observables = new List<IObservable<TValue>>();
    }

    public void AddObservable(IObservable<TValue> observable) => 
        Observables.Add(observable);

    public void RemoveObservable(IObservable<TValue> observable) =>
        Observables.Remove(observable);

    protected void NotifyObservables(TValue value) => 
        Observables.ForEach(o => o.Update(value));
}
