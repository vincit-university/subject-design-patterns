import java.util.ArrayList;
import java.util.List;

public class Publisher<TValue> {
    private List<IObservable<TValue>> observables;

    public Publisher() {
        observables = new ArrayList<>();
    }

    protected List<IObservable<TValue>> getObservables() {
        return observables;
    }

    public void addObservable(IObservable<TValue> observable) {
        observables.add(observable);
    }

    public void removeObservable(IObservable<TValue> observable) {
        observables.remove(observable);
    }

    public void notifyObservables(TValue value) {
        observables.forEach(o -> o.update(value));
    }
}
