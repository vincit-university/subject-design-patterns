from cafe_decorator import CafeDecorator

class CafeAdicionalDeAcucar(CafeDecorator):
    def __init__(self, cafe):
        super().__init__(cafe)
        
    def get_custo(self):
        custo = super().get_custo()
        custo = custo + 1.00
        return custo
    
    def get_descricao(self):
        descricao = super().get_descricao()
        descricao = f"{descricao} + Açucar"
        return descricao