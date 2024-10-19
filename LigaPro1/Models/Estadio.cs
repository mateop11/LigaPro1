using System.ComponentModel.DataAnnotations;

namespace LigaPro1.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Ciudad { get; set; }

        public int Capacidad { get; set; }

        public ICollection<Equipo> Equipos { get; set; }
    }
}
