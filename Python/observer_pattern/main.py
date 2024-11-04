import random
import time

from display_celsius_observable import DisplayCelsiusObservable
from display_farenheit_observable import DisplayFarenheitObservable
from estacao_meteorologica import EstacaoMeteorologica

estacao = EstacaoMeteorologica()
displayCelsius = DisplayCelsiusObservable()
displayFarenheit = DisplayFarenheitObservable()

estacao.add_observable(displayCelsius)
estacao.add_observable(displayFarenheit)

while True:
    temperatura = random.randint(18, 40)
    
    print("Atualizando a temperatura ...")
    estacao.set_temperatura(temperatura)
    print('\n')
    
    time.sleep(2)