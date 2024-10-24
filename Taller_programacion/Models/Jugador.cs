using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_programacion.Models
{
    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }

        [MaxLength(100)]
        public String Nombre { get; set; }

        [MaxLength(100)]
        public String Posición { get; set; }

        [MaxLength(100)]
        public String Edad { get; set; }      

        public Equipo? Equipo { get; set; }

        [ForeignKey(nameof(Equipo))]
        public int IdEquipo { get; set; }





    }
}
