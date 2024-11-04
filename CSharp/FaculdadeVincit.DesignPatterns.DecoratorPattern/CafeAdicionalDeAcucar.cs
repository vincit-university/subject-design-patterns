namespace FaculdadeVincit.DesignPatterns.DecoratorPattern;

public class CafeAdicionalDeAcucar : CafeDecorator
{
    public CafeAdicionalDeAcucar(ICafe cafe) : base(cafe)
    {
    }

    public override string Descricao => $"{base.Descricao} + Açucar";

    public override double Custo => base.Custo + 1.00;
}
