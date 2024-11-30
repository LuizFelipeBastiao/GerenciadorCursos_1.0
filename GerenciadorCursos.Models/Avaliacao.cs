namespace Models;
public class Avaliacao
{
   public int? Id { get; set; }
   public  string Pergunta { get; set; }
   public  string RespostaCerta { get; set; }
   public Licao Licao { get; set; }
   public ICollection<string> Opcoes { get; set; }
    public Avaliacao(int id,string pergunta,string respostac,Licao licao,ICollection<string> opcoes)
    {     
        Id = id;
        Pergunta = pergunta;
        Licao = licao;
        RespostaCerta = respostac;
        Opcoes = opcoes;

        
    }
    public bool Validar()
    {
        var ehvalido = !string.IsNullOrWhiteSpace(Pergunta) && !string.IsNullOrWhiteSpace(RespostaCerta);
        if (!ehvalido)
        {
            throw new Exception("Dados Inválidos");
        }
        return true;
    }
    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
        {
            return false;
        }
        var other = (Avaliacao) obj;
        return base.Equals(Id.HasValue && other.Id.HasValue && Id == other.Id);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

}
