using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Taller_programacion.Models
{
    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nombre { get; set; }
        [NotNull]

        [MaxLength(100)]
        public string Posición { get; set; }

        [MaxLength(100)]
        [Range(0, 50)]
        [NotNull]
        public string Edad { get; set; }      

        public Equipo? Equipo { get; set; }

        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }





    }
}
