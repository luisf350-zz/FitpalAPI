using Microsoft.EntityFrameworkCore;

namespace FitpalAPI.Models
{
    public class FitpalContext : DbContext
    {
        public FitpalContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TipoEntrenamiento> TipoEntrenamientos { get; set; }

        public DbSet<Ciudad> Ciudades { get; set; }
    }
}
