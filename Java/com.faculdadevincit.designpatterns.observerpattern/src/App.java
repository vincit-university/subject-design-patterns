public class App {
    public static void main(String[] args) throws Exception {
        EstacaoMeteorologica estacao = new EstacaoMeteorologica();
        DisplayCelsiusObservable displayCelsius = new DisplayCelsiusObservable();
        DisplayFarenheitObservable displayFarenheit = new DisplayFarenheitObservable();

        estacao.addObservable(displayCelsius);
        estacao.addObservable(displayFarenheit);

        do {
            double temperatura = (int) (Math.random() * (40 - 18)) + 18;

            System.out.println("Atualizando temperatura ...");
            estacao.setTemperatura(temperatura);
            System.out.println();

            Thread.sleep(2000);
        } while (true);

    }
}
