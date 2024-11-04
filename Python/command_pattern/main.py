from controle_remoto import ControleRemoto
from luz import Luz
from luz_desligar_command import LuzDesligarCommand
from luz_ligar_command import LuzLigarCommand


luz = Luz()
luzLigarCmd = LuzLigarCommand(luz)
luzDesligarCmd = LuzDesligarCommand(luz)

controle = ControleRemoto()

controle.command = luzLigarCmd
controle.pressionar_botao()

controle.command = luzDesligarCmd
controle.pressionar_botao()

controle.desfazer_pressionar()