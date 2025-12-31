using System.ComponentModel.DataAnnotations;

namespace GaleriaArte_mvc.Models
{
    public class Artista
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string Pais { get; set; } 
    }
}
