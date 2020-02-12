using Microsoft.EntityFrameworkCore;
using AppUser.Domain;

namespace AppUser.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Acesso> Acesso { get; set; }
        public DbSet<Sala> Sala { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
        {
            
        }
    }
}