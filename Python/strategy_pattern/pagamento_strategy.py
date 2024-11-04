from abc import ABC, abstractmethod

class PagamentoStrategy(ABC):
    @abstractmethod
    def pagar(self, valor):
        pass