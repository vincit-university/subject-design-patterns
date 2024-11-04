namespace FaculdadeVincit.DesignPatterns.CommandPattern;

public class ControleRemoto
{
    public ICommand? Command { get; set; }
    public void PressionarBotao() => Command?.Executar();
    public void DesfazerPressionar() => Command?.Desfazer();
}
