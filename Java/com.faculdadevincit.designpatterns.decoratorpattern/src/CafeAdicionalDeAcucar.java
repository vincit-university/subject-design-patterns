public class CafeAdicionalDeAcucar extends CafeDecorator {

    public CafeAdicionalDeAcucar(ICafe cafe) {
        super(cafe);
        //TODO Auto-generated constructor stub
    }

    @Override
    public double getCusto() {
        double custo = super.getCusto();
        custo += 1.00;
        return custo;
    }

    @Override
    public String getDescricao() {
        String descricao = super.getDescricao();
        descricao += " + Açucar";
        return descricao;
    }

}
