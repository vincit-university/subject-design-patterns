public class Sanduiche {
    private String pao;
    private String carne;
    private String queijo;
    private boolean temSalada;

    public String getPao() {
        return pao;
    }
    public void setPao(String pao) {
        this.pao = pao;
    }
    public String getCarne() {
        return carne;
    }
    public void setCarne(String carne) {
        this.carne = carne;
    }
    public String getQueijo() {
        return queijo;
    }
    public void setQueijo(String queijo) {
        this.queijo = queijo;
    }
    public boolean isTemSalada() {
        return temSalada;
    }
    public void setTemSalada(boolean temSalada) {
        this.temSalada = temSalada;
    }

    public void mostrarInformacoesPedido() {
        StringBuilder textoBuilder = new StringBuilder();
        textoBuilder.append("Sanduiche: ")
                    .append(pao)
                    .append(" com ")
                    .append(carne)
                    .append(", queijo ")
                    .append(queijo)
                    .append(" e ")
                    .append(temSalada ? "com " : "sem ")
                    .append("Salada.");

        String texto = textoBuilder.toString();
        System.out.println(texto);
    }
}
