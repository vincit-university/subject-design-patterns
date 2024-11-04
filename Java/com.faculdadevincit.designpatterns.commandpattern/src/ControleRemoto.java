public class ControleRemoto {
    private ICommand comand;

    public ICommand getComand() {
        return comand;
    }

    public void setComand(ICommand comand) {
        this.comand = comand;
    }

    public void pressionarBotao() {
        comand.executar();
    }

    public void desfazerPressionar() {
        comand.desfazer();
    }
}
