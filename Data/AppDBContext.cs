using Microsoft.EntityFrameworkCore;

namespace CassioJhones.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Curso> Cursos { get; set; }
    }
}
