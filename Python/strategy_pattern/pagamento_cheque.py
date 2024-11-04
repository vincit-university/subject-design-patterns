from pagamento_strategy import PagamentoStrategy

class PagamentoCheque(PagamentoStrategy):
    def pagar(self, valor):
        print(f"Pagamento de R$ {valor} realizado com Cheque!")