using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_programacion.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(100)]

        public string Ciudad { get; set; }

        [MaxLength(100)]
        public string Titulos { get; set; }
       

        public Boolean AceptaExtranjero { get; set; }

        public Estadio? Estadio { get; set; }

        [ForeignKey(nameof(Estadio))]
        public int IdEstadio { get; set; }
        

    }
}
