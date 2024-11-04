namespace FaculdadeVincit.DesignPatterns.CommandPattern;

public class LuzLigarCommand : ICommand
{
    public Luz Luz { get; private set; }

    public LuzLigarCommand(Luz luz)
    {
        Luz = luz;
    }

    public void Executar() => Luz.Ligar();
    public void Desfazer() => Luz.Desligar();

}
