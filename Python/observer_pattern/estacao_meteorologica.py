from publisher import Publisher


class EstacaoMeteorologica(Publisher[float]):
    temperatura: float = 0
    
    def __init__(self):
        super().__init__()

    def set_temperatura(self, value: float):
        self.temperatura = value
        self.notify_observables(self.temperatura)