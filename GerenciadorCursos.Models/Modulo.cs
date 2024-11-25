
using Models;

namespace GerenciadorCursos.Models
{
    public class Modulo
    {
      public  int? Id { get; set; }
      public string Titulo { get; set; }
      public  Curso Curso { get; set; }
      public  ICollection<Licao> licao { get; set; }

        public Modulo()
        {
            licao  = new List<Licao>();
        }
        public Modulo(int? id, string titulo, Curso curso, ICollection<Licao> licoes)
        {
            Id = id;
            Titulo = titulo;
            Curso = curso;
            licao = licoes;
        }
        public bool Validar()
        {
            var ehvalido = !string.IsNullOrWhiteSpace(Titulo);
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

