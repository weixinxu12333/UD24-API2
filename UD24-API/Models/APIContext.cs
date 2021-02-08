using Microsoft.EntityFrameworkCore;
using UD24_API.Models;

namespace UD24_API.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
            : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<UD24_API.Models.Video> Videos { get; set; }

    }
}
