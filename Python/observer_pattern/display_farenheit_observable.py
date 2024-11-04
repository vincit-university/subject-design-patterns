from observable import Observable

class DisplayFarenheitObservable(Observable[float]):
    def update(self, value: float):
        farenheit = (value * 9 / 5) + 32
        print(f"Temperatura em Farenheit: {farenheit} º F!")