using System;
using System.ComponentModel.DataAnnotations;

namespace FitpalAPI.Models
{
    public class TipoEntrenamiento
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
