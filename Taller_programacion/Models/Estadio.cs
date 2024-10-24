using System.ComponentModel.DataAnnotations;

namespace Taller_programacion.Models
{
    public class Estadio
    {
        [Key]
        public int IdEstadio { get; set; }

        [MaxLength(100)]
        public string Dirección { get; set; }

        [MaxLength(100)]
        public string Ciudad {  get; set; }

        [MaxLength(100)]
        public int Capacidad { get; set; }
        




    }
}
