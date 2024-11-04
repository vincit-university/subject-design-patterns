from pagamento_cartao_de_credito import PagamentoCartaoDeCredito
from pagamento_cheque import PagamentoCheque
from pagamento_pix import PagamentoPix
from sacola_de_compras import SacolaDeCompras


sacola = SacolaDeCompras()
sacola.pagamento = PagamentoCheque()
sacola.realizar_pagamento(1500)
print('\n')

sacola.pagamento = PagamentoCartaoDeCredito()
sacola.realizar_pagamento(1300)
print('\n')

sacola.pagamento = PagamentoPix()
sacola.realizar_pagamento(1100)