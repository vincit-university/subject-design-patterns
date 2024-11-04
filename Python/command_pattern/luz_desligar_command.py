from command import Command
from luz import Luz


class LuzDesligarCommand(Command):
    def __init__(self, luz : Luz):
        self.luz = luz
        
    def executar(self):
        self.luz.desligar()
        
    def desfazer(self):
        self.luz.ligar()