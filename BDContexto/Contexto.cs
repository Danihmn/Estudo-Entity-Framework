using EF_Core.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EF_Core.BDContexto
{
    internal class Contexto : DbContext
    {
        public DbSet<Filme> Filmes { get; set; } // Tabela de filmes
        public DbSet<Diretor> Diretores { get; set; } // Tabela de diretores

        // Estabelece conexão com o banco de dados SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=EFCoreConsole.db");
    }
}
