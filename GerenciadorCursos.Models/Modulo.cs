﻿
using Models;

namespace GerenciadorCursos.Models
{
    public class Modulo
    {
        int Id { get; set; }
        string Titulo { get; set; }
       public  Curso Curso { get; set; }
        ICollection<Licao> licoes { get; set; }

        public Modulo()
        {
            licoes  = new List<Licao>();
        }
    }
}
