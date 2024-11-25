using GerenciadorCursos.Models;

namespace Models
{
    public class Licao
    {
       public int? Id { get; set; }
       public   string Titulo { get; set; }
       public string Conteudo { get; set; }
       public Modulo Modulo { get; set; }
      public  ICollection<Avaliacao> Avaliacoes { get; set; }
        public Licao()
        {
            Avaliacoes = new List<Avaliacao>();
        }
        public Licao(int id, string titulo, string conteudo, Modulo modulo, ICollection<Avaliacao> avaliacoes)
        {
            Id = id;
            Titulo = titulo;
            Conteudo = conteudo;
            Modulo = modulo;
            Avaliacoes = avaliacoes;
        }
        public bool Validar()
        {
            var ehvalido = !string.IsNullOrWhiteSpace(Titulo) && !string.IsNullOrWhiteSpace(Conteudo);
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
}
