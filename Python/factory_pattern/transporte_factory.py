from transporte import Transporte
from transporte_aquatico import TransporteAquatico
from transporte_enum import TransporteEnum
from transporte_ferroviario import TransporteFerroviario
from transporte_rodoviario import TransporteRodoviario

class TransporteFactory:
    @staticmethod
    def create_transporte(transporteEnum) -> Transporte:
        switcher = {
            TransporteEnum.AQUATICO: TransporteAquatico(),
            TransporteEnum.FERROVIARIO : TransporteFerroviario(),
            TransporteEnum.RODOVIARIO : TransporteRodoviario()
        }
        
        return switcher.get(transporteEnum)