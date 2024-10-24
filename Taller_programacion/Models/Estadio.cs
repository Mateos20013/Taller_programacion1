using System.ComponentModel.DataAnnotations;

namespace Taller_programacion.Models
{
    public class Estadio
    {
        [Key]
        public int IdEstadio { get; set; }
        [Required]
        [MaxLength(100)]
        public string Dirección { get; set; }
        [Required]
        [MaxLength(50)]
        public string Ciudad {  get; set; }
        [Required]
        [MaxLength(100)]
        public int Capacidad { get; set; }
        




    }
}
