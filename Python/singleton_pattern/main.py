from contador_singleton import ContadorSingleton

contador1 = ContadorSingleton()
contador2 = ContadorSingleton()
contador3 = ContadorSingleton()

contador1.incrementar()
contador2.incrementar()
contador3.incrementar()

print(f"Contador 1: {contador1.valor}")
print(f"Contador 2: {contador2.valor}")
print(f"Contador 3: {contador3.valor}")