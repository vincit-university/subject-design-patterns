public class DisplayFarenheitObservable implements IObservable<Double>{

    @Override
    public void update(Double value) {
        double farenheit = (value * 9 / 5) + 32;
        System.out.println("Temperatura em Farenheit: " + farenheit + " ºF");
    }

}
