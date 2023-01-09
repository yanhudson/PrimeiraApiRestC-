using Microsoft.EntityFrameworkCore;
using Domain;

namespace Dao
{
    public class ClienteDao : DbContext
    {
        public ClienteDao(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; } 
    }
}