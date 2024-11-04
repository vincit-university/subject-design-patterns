namespace FaculdadeVincit.DesignPatterns.BulderPattern;

public class Sanduiche
{
    public string Pao { get; set; }
    public string Carne { get; set; }
    public string Queijo { get; set; }
    public bool TemSalada { get; set; }
    public Sanduiche(string pao, string carne, string queijo, bool temSalada)
    {
        Pao = pao;
        Carne = carne;
        Queijo = queijo;
        TemSalada = temSalada;
    }

    public void MostrarInformacoesPedido() {
        var texto = $"Sanduiche: {Pao} com {Carne}";
        texto += $" queijo {Queijo} e ";
        texto += TemSalada ? "com" : "sem";
        texto += " salada.";

        System.Console.WriteLine(texto);
    }
}
