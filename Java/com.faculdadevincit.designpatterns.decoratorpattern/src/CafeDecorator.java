public abstract class CafeDecorator implements ICafe {
    protected ICafe cafe;

    public CafeDecorator(ICafe cafe) {
        this.cafe = cafe;
    }

    @Override
    public double getCusto() {
        return cafe.getCusto();
    }

    @Override
    public String getDescricao() {
        return cafe.getDescricao();
    }

}
