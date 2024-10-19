using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LigaPro1.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Posicion { get; set; }

        public int Edad { get; set; }

        [ForeignKey("Equipo")]
        public int EquipoId { get; set; }

        public Equipo Equipo { get; set; }
    }
}
