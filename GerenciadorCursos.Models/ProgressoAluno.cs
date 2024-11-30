namespace Models;
public class ProgressoAluno
{
    int Id { get; set; }

    public Usuario Aluno { get; set; } = null;
    public Curso Curso { get; set; } = null;
    float PercentualConclusao { get; set; }
}
