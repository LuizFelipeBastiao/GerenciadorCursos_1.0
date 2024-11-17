namespace Models;

public enum TipoUsuario
{
    Aluno,
    Instrutor,
    Administrador
}
public class Usuario
{
    int Id { get; set; }
    string Nome { get; set; } = null;
    string Email { get; set; }
    string SenhaHash { get; set; }
    TipoUsuario Tipo { get; set; }

    
}
