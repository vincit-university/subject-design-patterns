from pagamento_strategy import PagamentoStrategy


class PagamentoPix(PagamentoStrategy):
    def pagar(self, valor):
        desconto = valor * .10
        valorComDesconto = valor - desconto
        print(f"Pagamento de R$ {valorComDesconto} no Pix!")
        print(f"Desconto de R$ {valorComDesconto} à vista!")
        