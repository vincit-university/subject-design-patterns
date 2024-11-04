
using FaculdadeVincit.DesignPatterns.StrategyPattern;

var sacola = new SacolaDeCompras();

sacola.Pagamento = new PagamentoCheque();
sacola.RealizarPagamento(1500);
Console.WriteLine();

sacola.Pagamento = new PagamentoComCartaoDeCredito();
sacola.RealizarPagamento(1300);
Console.WriteLine();

sacola.Pagamento = new PagamentoPix();
sacola.RealizarPagamento(1100);