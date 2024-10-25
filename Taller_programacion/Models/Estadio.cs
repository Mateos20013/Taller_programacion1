using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Taller_programacion.Models
{
    public class Estadio
    {
        [Key]
        public int IdEstadio { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        public string Dirección { get; set; }
        [Required]
        [MaxLength(50)]
        public string Ciudad {  get; set; }
        [Required]
        [MaxLength(100)]
        [NotNull]
        public string? Capacidad { get; set; }
        




    }
}
