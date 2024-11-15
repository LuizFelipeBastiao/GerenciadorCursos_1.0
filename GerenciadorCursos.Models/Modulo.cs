
using Models;

namespace GerenciadorCursos.Models
{
    internal class Modulo
    {
        int Id { get; set; }
        string Titulo { get; set; }
        Curso Curso { get; set; }
        ICollection<Licao> licoes { get; set; }

        public Modulo()
        {
            licoes  = new List<Licao>();
        }
    }
}
