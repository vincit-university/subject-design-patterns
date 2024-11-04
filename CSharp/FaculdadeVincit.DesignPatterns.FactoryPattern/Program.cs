using FaculdadeVincit.DesignPatterns.FactoryPattern;

ITransporte transporte1 = TransporteFactory.CreateTransporte(TransporteEnum.AQUATICO);
ITransporte transporte2 = TransporteFactory.CreateTransporte(TransporteEnum.RODOVIARIO);
ITransporte transporte3 = TransporteFactory.CreateTransporte(TransporteEnum.FERROVIARIO);

transporte1.Entregar();
transporte2.Entregar();
transporte3.Entregar();