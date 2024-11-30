using GerenciadorCursos.Models;

namespace Models
{
    public class Licao
    {
        int Id { get; set; }
        string Titulo { get; set; }
        string Conteudo { get; set; }
        public Modulo Modulo { get; set; }
        ICollection<Avaliacao> Avaliacoes { get; set; }
        public Licao()
        {
            Avaliacoes = new List<Avaliacao>();
        }

    }
}
