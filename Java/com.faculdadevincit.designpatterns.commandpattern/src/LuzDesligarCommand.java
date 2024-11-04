public class LuzDesligarCommand implements ICommand {
    private Luz luz;

    public LuzDesligarCommand(Luz luz) {
        this.luz = luz;
    }

    @Override
    public void executar() {
        luz.desligar();
    }

    @Override
    public void desfazer() {
        luz.ligar();
    }

}
