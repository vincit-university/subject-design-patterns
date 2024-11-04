public class LuzLigarCommand implements ICommand{
    private Luz luz;

    public LuzLigarCommand(Luz luz) {
        this.luz = luz;
    }

    @Override
    public void executar() {
        luz.ligar();
    }

    @Override
    public void desfazer() {
        luz.desligar();
    }

}
