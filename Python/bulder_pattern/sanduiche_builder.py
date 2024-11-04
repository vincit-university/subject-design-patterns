from sanduiche import Sanduiche


class SanduicheBuilder:
    def set_pao(self, pao):
        self.pao = pao
        return self
        
    def set_carne(self, carne):
        self.carne = carne
        return self
        
    def set_queijo(self, queijo):
        self.queijo = queijo
        return self
        
    def set_tem_salada(self, tem_salada):
        self.tem_salada = tem_salada
        return self
    
    def build(self):
        sanduiche = Sanduiche()
        sanduiche.pao = self.pao
        sanduiche.carne = self.carne
        sanduiche.queijo = self.queijo
        sanduiche.tem_salada = self.tem_salada
        
        return sanduiche