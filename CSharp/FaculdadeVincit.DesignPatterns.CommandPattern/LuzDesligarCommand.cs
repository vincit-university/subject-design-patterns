namespace FaculdadeVincit.DesignPatterns.CommandPattern;

public class LuzDesligarCommand : ICommand
{
    public Luz Luz { get; private set; }

    public LuzDesligarCommand(Luz luz)
    {
        Luz = luz;
    }

    public void Executar() => Luz.Desligar();

    public void Desfazer() => Luz.Ligar();
}
