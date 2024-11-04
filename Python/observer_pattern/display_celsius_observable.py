from observable import Observable

class DisplayCelsiusObservable(Observable[float]):
    def update(self, value: float):
        print(f"Temperatura em Célsius: {value} ºC!")