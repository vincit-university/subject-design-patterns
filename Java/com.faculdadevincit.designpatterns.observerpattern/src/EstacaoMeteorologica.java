public class EstacaoMeteorologica extends Publisher<Double> {
    private double temperatura;

    public double getTemperatura() {
        return temperatura;
    }

    public void setTemperatura(double temperatura) {
        this.temperatura = temperatura;
        notifyObservables(this.temperatura);
    }
}
