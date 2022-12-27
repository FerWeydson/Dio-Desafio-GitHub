using Microsoft.EntityFrameworkCore;
using WebMVCMysql1.Models;

namespace WebMVCMysql1.Data
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
