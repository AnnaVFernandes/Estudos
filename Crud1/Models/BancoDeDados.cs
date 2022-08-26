using Microsoft.EntityFrameworkCore;

namespace Crud1.Models
{
    public class BancoDeDados : DbContext
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)


    {
        optionsBuilder.UseSqlServer(connectionString:);
    }
}
