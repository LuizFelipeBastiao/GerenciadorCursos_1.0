using GerenciadorCursos.Models;

namespace Models;


    public enum StatusCurso
    {
        ativo,
        inativo
    }
public class Curso
{
    int Id { get; set; }
    string TituloCurso { get; set; }
    string Descricao { get; set; }
    float PrecoCurso { get; set; }
    ICollection<Modulo> Modulos { get; set; }
    StatusCurso Status { get; set; }

    public Curso(){
        Modulos = new List<Modulo>();
    }

}
