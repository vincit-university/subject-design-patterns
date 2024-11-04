namespace FaculdadeVincit.DesignPatterns.FactoryPattern;

public static class TransporteFactory
{
    public static ITransporte CreateTransporte(TransporteEnum transporteEnum)
    {
        switch (transporteEnum)
        {
            case TransporteEnum.AQUATICO:
                return new TransporteAquatico();
            case TransporteEnum.FERROVIARIO:
                return new TransporteFerroviario();
            case TransporteEnum.RODOVIARIO:
                return new TransporteRodoviario();
        }

        throw new NotImplementedException();
    }
}
