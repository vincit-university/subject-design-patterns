using FaculdadeVincit.DesignPatterns.FacadePattern;

var loja = new LojaFacade();

loja.FazerPedido("Laptop", 2999.90m);
loja.FazerPedido("Smartphone", 1999.90m);
loja.FazerPedido("Jogo de Mesa com 4 Cadeiras", 699.90m);