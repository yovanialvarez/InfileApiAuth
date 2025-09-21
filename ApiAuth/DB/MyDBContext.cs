using ApiAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAuth.DB
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
