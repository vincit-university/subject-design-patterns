class Sanduiche:
    def __init__(self, pao=None, carne=None, queijo=None, tem_salada=None):
        self.pao = pao
        self.carne = carne
        self.queijo = queijo
        self.tem_salada = tem_salada
        
    def mostrar_informacoes_pedido(self):
        texto = f'Sanduiche: {self.pao} com carne {self.carne},'
        texto += f'queijo {self.queijo} '
        texto += f'com ' if self.tem_salada else 'sem'
        texto += 'salada'
        
        print(texto)