using GerenciadorCursos.Models;

namespace Models;
    public enum StatusCurso
    {
        ativo,
        inativo
    }
public class Curso
{
   public int? Id { get; set; }
   public string TituloCurso { get; set; }
   public string Descricao { get; set; }
   public float PrecoCurso { get; set; }
   public  ICollection<Modulo> Modulos { get; set; }
   public StatusCurso Status { get; set; }

    public Curso(){
        Modulos = new List<Modulo>();
    }
    public Curso(int? id, string tituloCurso, string descricao, float precoCurso, ICollection<Modulo> modulos, StatusCurso status)
    {
        Id = id;
        TituloCurso = tituloCurso;
        Descricao = descricao;
        PrecoCurso = precoCurso;
        Modulos = modulos;
        Status = status;
    }
    public bool Validar()
    {
        var ehvalido = !string.IsNullOrWhiteSpace(TituloCurso) && !string.IsNullOrWhiteSpace(Descricao);
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
        var other = (Avaliacao)obj;
        return base.Equals(Id.HasValue && other.Id.HasValue && Id == other.Id);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
