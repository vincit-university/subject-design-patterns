from abc import ABC, abstractmethod

class Transporte(ABC):
    @abstractmethod
    def entregar(self):
        pass