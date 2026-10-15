using System.ComponentModel.DataAnnotations;

namespace UtlvteMonolito.Web.Models
{
    public class Asignatura
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El código es obligatorio.")]
        public string Codigo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        public int Creditos { get; set; }

        public string Nivel { get; set; } = string.Empty;

        public ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
    }
}
