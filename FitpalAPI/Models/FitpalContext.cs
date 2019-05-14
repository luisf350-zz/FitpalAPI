using Microsoft.EntityFrameworkCore;
using System;

namespace FitpalAPI.Models
{
    public class FitpalContext : DbContext
    {
        public FitpalContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public DbSet<TipoEntrenamiento> TipoEntrenamientos { get; set; }

        public DbSet<Ciudad> Ciudades { get; set; }
    }
}
