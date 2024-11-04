from abc import ABC, abstractmethod

class Command(ABC):
    @abstractmethod
    def executar(self):
        pass
    
    @abstractmethod
    def desfazer(self):
        pass