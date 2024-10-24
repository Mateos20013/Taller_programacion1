using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

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
        [Range(0, 50)]
        public string Titulos { get; set; }
        [NotNull]

        public Boolean AceptaExtranjero { get; set; }

        public Estadio? Estadio { get; set; }

        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }
        

    }
}
