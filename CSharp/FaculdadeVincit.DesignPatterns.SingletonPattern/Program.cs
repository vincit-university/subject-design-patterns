using FaculdadeVincit.DesignPatterns.SingletonPattern;

ContadorSingleton contador1, contador2, contador3;

contador1 = ContadorSingleton.Instance;
contador2 = ContadorSingleton.Instance;
contador3 = ContadorSingleton.Instance;

contador1.Incrementar();
contador2.Incrementar();
contador3.Incrementar();

System.Console.WriteLine($"Contador1: {contador1.Valor}");
System.Console.WriteLine($"Contador2: {contador2.Valor}");
System.Console.WriteLine($"Contador3: {contador3.Valor}");