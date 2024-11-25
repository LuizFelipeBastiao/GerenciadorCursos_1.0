namespace Models;
public class ProgressoAluno
{
    public int? Id { get; set; }

    public Usuario Aluno { get; set; } = null;
    public Curso Curso { get; set; } = null;
    float PercentualConclusao { get; set; }

    public ProgressoAluno(int id, Usuario aluno, Curso curso, float percentualConclusao)
    {
        Id = id;
        Aluno = aluno;
        Curso = curso;
        PercentualConclusao = percentualConclusao;
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

