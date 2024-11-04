public class CafeAdicionalDeLeite extends CafeDecorator{

    public CafeAdicionalDeLeite(ICafe cafe) {
        super(cafe);
        //TODO Auto-generated constructor stub
    }

    @Override
    public double getCusto() {
        double custo = super.getCusto();
        custo += 2.50;
        return custo;
    }

    @Override
    public String getDescricao() {
        String descricao = super.getDescricao();
        descricao += " + Leite";
        return descricao;
    }

}
