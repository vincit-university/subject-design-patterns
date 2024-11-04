from command import Command

class ControleRemoto:
    command : Command = None
    
    def pressionar_botao(self):
        self.command.executar()
        
    def desfazer_pressionar(self):
        self.command.desfazer()