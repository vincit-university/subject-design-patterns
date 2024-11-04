from transporte_enum import TransporteEnum
from transporte_factory import TransporteFactory

transporte1 = (TransporteFactory
               .create_transporte(TransporteEnum.RODOVIARIO))

transporte2 = (TransporteFactory
               .create_transporte(TransporteEnum.FERROVIARIO))

transporte3 = (TransporteFactory
               .create_transporte(TransporteEnum.AQUATICO))

transporte1.entregar()
transporte2.entregar()
transporte3.entregar()