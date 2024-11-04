from pagamento_strategy import PagamentoStrategy

class SacolaDeCompras:
    pagamento : PagamentoStrategy = None
    
    def realizar_pagamento(self, valor: float):
        if self.pagamento is None:
            print("Método de pagamento não definido")
        else:
            self.pagamento.pagar(valor)