using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    // classe q representa o banco de dados
    public class AppDbContext : DbContext
    {
        //propriedade q representa a tabela Usuarios
        public DbSet<Usuario> Usuarios { get; set; }

        //metodos q configuram informando para a BF que o banco será SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }

}
