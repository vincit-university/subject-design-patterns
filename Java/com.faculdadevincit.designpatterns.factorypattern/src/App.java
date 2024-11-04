public class App {
    public static void main(String[] args) throws Exception {
        ITransporte transporte1 = TransporteFactory.createTransporte(TransporteEnum.AQUATICO);
        ITransporte transporte2 = TransporteFactory.createTransporte(TransporteEnum.FERROVIARIO);
        ITransporte transporte3 = TransporteFactory.createTransporte(TransporteEnum.RODOVIARIO);

        transporte1.entregar();
        transporte2.entregar();
        transporte3.entregar();
    }
}
