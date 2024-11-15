namespace Models;
public class Usuario
{
    int Id { get; set; }
    string Nome { get; set; }
    string Email { get; set; }
    string SenhaHash { get; set; }

    //TipoUsuario Tipo { get; set; }
}
