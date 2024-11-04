
from sanduiche_builder import SanduicheBuilder

sanduiche_builder = SanduicheBuilder()
sanduiche = (sanduiche_builder
             .set_pao("Brioche")
             .set_carne("Bovina")
             .set_queijo("Prato")
             .set_tem_salada(True)
             .build())

sanduiche.mostrar_informacoes_pedido()