
using FaculdadeVincit.DesignPatterns.ObserverPattern;

var estacao = new EstacaoMeteorologica();
var displayCelsius = new DisplayCelsiusObservable();
var displayFarenheit = new DisplayFarenheitObservable();

estacao.AddObservable(displayCelsius);
estacao.AddObservable(displayFarenheit);


do {
    var temperatura = new Random().Next(18, 40);

    Console.WriteLine("Atualizando a temperatura ...");
    estacao.Temperatura = temperatura;
    Console.WriteLine();

    Thread.Sleep(2000);
} while(true);