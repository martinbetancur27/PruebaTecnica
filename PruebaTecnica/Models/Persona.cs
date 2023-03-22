using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Models
{
    public class Persona
    {
        [Key]
        public Guid Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Identificacion { get; set; }

        public string Genero { get; set; }

        public string Telefono { get; set; }

        public string CorreoElectronico { get; set; }
    }
}