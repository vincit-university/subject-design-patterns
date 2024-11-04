from processador_de_pedidos import ProcessadorDePedidos
from sistema_de_envio import SistemaDeEnvio
from sistema_de_pagamentos import SistemaDePagamentos


class LojaFacade:
    def __init__(self):
        self.processador_de_pedidos = ProcessadorDePedidos()
        self.sistema_de_pagamentos = SistemaDePagamentos()
        self.sistema_de_envio = SistemaDeEnvio()
        
    def fazer_pedido(self, item, valor):
        self.processador_de_pedidos.criar_pedido(item)
        self.sistema_de_pagamentos.processar_pagamento(valor)
        self.sistema_de_envio.enviar_pedido(item)
        
        print("Pedido realizado com sucesso!\n")