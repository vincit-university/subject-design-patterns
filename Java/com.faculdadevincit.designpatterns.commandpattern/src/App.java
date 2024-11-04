public class App {
    public static void main(String[] args) throws Exception {
        Luz luz = new Luz();
        LuzLigarCommand luzLigarCmd = new LuzLigarCommand(luz);
        LuzDesligarCommand luzDesligarCmd = new LuzDesligarCommand(luz);

        ControleRemoto controle = new ControleRemoto();

        controle.setComand(luzLigarCmd);
        controle.pressionarBotao();

        controle.setComand(luzDesligarCmd);
        controle.pressionarBotao();

        controle.desfazerPressionar();
    }
}
