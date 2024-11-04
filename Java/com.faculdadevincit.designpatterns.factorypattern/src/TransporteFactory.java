public class TransporteFactory {
    public static ITransporte createTransporte(TransporteEnum transporteEnum) {
        switch (transporteEnum) {
            case AQUATICO:
                return new TransporteAquatico();
            case FERROVIARIO:
                return new TransporteFerroviario();
            case RODOVIARIO:
                return new TransporteRodoviario();
        }

        throw new UnsupportedOperationException();
    }
}
