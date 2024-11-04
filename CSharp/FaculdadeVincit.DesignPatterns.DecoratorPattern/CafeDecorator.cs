namespace FaculdadeVincit.DesignPatterns.DecoratorPattern;

public class CafeDecorator : ICafe
{
    protected ICafe _cafe;

    public CafeDecorator(ICafe cafe)
    {
        _cafe = cafe;
    }

    public virtual string Descricao => _cafe.Descricao;

    public virtual double Custo => _cafe.Custo;

}
