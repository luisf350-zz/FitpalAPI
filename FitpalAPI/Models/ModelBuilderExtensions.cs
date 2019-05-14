using Microsoft.EntityFrameworkCore;
using System;

namespace FitpalAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Tipo Entrenamiento
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Acroyoga", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Aeroyoga", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Artes Marciales", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Baile/Danza", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Barre", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Bienestar", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Boxeo", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Complementa tu entrenamiento!", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Crossfit", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Crosstraining", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Deportes", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "EMS", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Entrenamiento personalizado", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Esferokinosis®", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Funcional", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Gimnasia Rítmica Expresiva", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Golfito", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Gym time", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "HIIT", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Indoor Cycling", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Jiu Jitsu Brasilero", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Karate", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Kids", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Levantamiento de pesas", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Lucha Olímpica", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Muay Thai - Kick Boxing", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Natación", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Pilates", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Power plate", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Sauna/Turco", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Spinning", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Tenis", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Valoración Física", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Weight Lifting", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Yoga", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<TipoEntrenamiento>().HasData(new TipoEntrenamiento { Id = Guid.NewGuid(), Nombre = "Yoga pilates", FechaCreacion = DateTime.Now });

        }
    }
}
