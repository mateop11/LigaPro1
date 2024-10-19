using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LigaPro1.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Ciudad { get; set; }

        public int Titulos { get; set; }

        public bool AceptaExtranjeros { get; set; }

        [ForeignKey("Estadio")]
        public int EstadioId { get; set; }

        public Estadio Estadio { get; set; }

        public ICollection<Jugador> Jugadores { get; set; }
    }
}
