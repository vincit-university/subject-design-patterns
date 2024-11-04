from cafe import Cafe

class CafeDecorator(Cafe):
    def __init__(self, cafe):
        self.cafe = cafe
        
    def get_descricao(self):
        return self.cafe.get_descricao()
    
    def get_custo(self):
        return self.cafe.get_custo()