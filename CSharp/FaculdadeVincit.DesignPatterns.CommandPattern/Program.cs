using FaculdadeVincit.DesignPatterns.CommandPattern;

var luz = new Luz();
var luzLigarCmd = new LuzLigarCommand(luz);
var luzDesligarCmd = new LuzDesligarCommand(luz);

var controle = new ControleRemoto();

controle.Command = luzLigarCmd;
controle.PressionarBotao();

controle.Command = luzDesligarCmd;
controle.PressionarBotao();

controle.DesfazerPressionar();