namespace Models;
internal class ProgressoAluno
{
    int Id { get; set; }

    Usuario Aluno { get; set; }
    Curso Curso { get; set; }
    float PercentualConclusao { get; set; }
}
