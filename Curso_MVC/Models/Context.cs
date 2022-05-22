
using Microsoft.EntityFrameworkCore;

namespace Curso_MVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"data source=LUCASMARQUES\SQLEXPRESS;initial catalog=master;trusted_connection=true");
        }
    }
}
