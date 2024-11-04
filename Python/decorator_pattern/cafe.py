from abc import ABC, abstractmethod

class Cafe(ABC):
    @abstractmethod
    def get_descricao(self):
        pass
    
    @abstractmethod
    def get_custo(self):
        pass