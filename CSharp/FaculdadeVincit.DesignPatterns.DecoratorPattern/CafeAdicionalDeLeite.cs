namespace FaculdadeVincit.DesignPatterns.DecoratorPattern;

public class CafeAdicionalDeLeite : CafeDecorator
{
    public CafeAdicionalDeLeite(ICafe cafe) : base(cafe)
    {
    }

    public override string Descricao => $"{base.Descricao} + Leite";
    public override double Custo => base.Custo + 2.50;

}
