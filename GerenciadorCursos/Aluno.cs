using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCursos;
public class Aluno
{
    public string nome { get; set; }
    public string email { get; set; }

    public string dataNasc { get; set; }

    public string cpf { get; set; }

    public string rg { get; set; }

    public string endereco { get; set; }

    public string telefone { get; set; }

    public override string ToString()
    {
        return $"[{nome}, {email}, {cpf}]";
    }
}
