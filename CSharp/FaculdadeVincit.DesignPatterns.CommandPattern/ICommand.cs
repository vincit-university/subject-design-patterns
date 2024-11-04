namespace FaculdadeVincit.DesignPatterns.CommandPattern;

public interface ICommand
{
    void Executar();
    void Desfazer();
}
