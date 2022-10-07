using Microsoft.EntityFrameworkCore;

namespace Crud1.Models
{
    public class BancoDeDados : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocal;Database=Crud1;Integreted Security=True");
        }

    }
}
