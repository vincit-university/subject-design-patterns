public class SanduicheBuilder {
    private String pao;
    private String carne;
    private String queijo;
    private boolean temSalada;

    public SanduicheBuilder setPao(String pao) {
        this.pao = pao;
        return this;
    }
    public SanduicheBuilder setCarne(String carne) {
        this.carne = carne;
        return this;
    }
    public SanduicheBuilder setQueijo(String queijo) {
        this.queijo = queijo;
        return this;
    }
    public SanduicheBuilder setTemSalada(boolean temSalada) {
        this.temSalada = temSalada;
        return this;
    }

    public Sanduiche Build() {
        Sanduiche sanduiche = new Sanduiche();
        sanduiche.setPao(pao);
        sanduiche.setCarne(carne);
        sanduiche.setQueijo(queijo);
        sanduiche.setTemSalada(temSalada);

        return sanduiche;
    }
}
