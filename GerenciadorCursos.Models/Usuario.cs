namespace Models;

public enum TipoUsuario
{
    Aluno,
    Instrutor,
    Administrador
}
public class Usuario
{
   public int? Id { get; set; }
   public string Nome { get; set; } = null;
   public string Email { get; set; }
   public string SenhaHash { get; set; }
   TipoUsuario Tipo { get; set; }

    public Usuario(int id, string nome, string email, string senhahash,TipoUsuario tipo)
    {
        Id = id;
        Nome = nome;
        Email = email;
        SenhaHash = senhahash;
        Tipo = tipo;

    }
    public bool Validar()
    {
        var ehvalido = !string.IsNullOrWhiteSpace(Nome) && !string.IsNullOrWhiteSpace(Email) 
            && !string.IsNullOrWhiteSpace(SenhaHash);
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

