namespace Models;
public class Avaliacao
{
    int Id { get; set; }
    string Pergunta { get; set; }
    string RespostaCerta { get; set; }
    Licao Licao { get; set; }
    ICollection<string> Opcoes { get; set; }
    public Avaliacao()
    {
        Opcoes = new List<string>();
    }

    

}
