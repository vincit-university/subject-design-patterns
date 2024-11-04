from command import Command
from luz import Luz


class LuzLigarCommand(Command):
    def __init__(self, luz: Luz) -> None:
        self.luz = luz
    
    def executar(self):
        self.luz.ligar()
    
    def desfazer(self):
        self.luz.desligar()