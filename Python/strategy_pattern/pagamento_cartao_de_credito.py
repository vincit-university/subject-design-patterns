from pagamento_strategy import PagamentoStrategy


class PagamentoCartaoDeCredito(PagamentoStrategy):
    def pagar(self, valor):
        acrescimo = valor * .10
        valorComAcrescimo = valor + acrescimo
        print(f"Pagamento de R$ {valorComAcrescimo} realizado com Cartão de Crédito!")
        print(f"Acréscimo de R$ {acrescimo} no Cartão!")