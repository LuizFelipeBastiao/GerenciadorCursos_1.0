using GerenciadorCursos.Models;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection.Metadata;

namespace MauiSqliteClassLibrary
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        // Constructor with no argument is required and it is used when adding/removing migrations from class library
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
            Database.Migrate();
        }

        // It is required to override this method when adding/removing migrations from class library
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source = linguica.db");

        public Microsoft.EntityFrameworkCore.DbSet<Avaliacao>? Avaliacoes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Curso>? Cursos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Licao>? Licoes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Modulo>? Modulos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ProgressoAluno>? Progressos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Usuario>? Usuarios { get; set; }
    }
}
