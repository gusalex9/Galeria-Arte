using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace GaleriaArte_mvc.Models
{
    public class Obra
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Titulo { get; set; }
        [StringLength(100)]
        public string Estilo { get; set; }
        [StringLength(250)]
        public string UrlImagen { get; set; }
        public Guid ArtistaID { get; set; }
        public Artista? Artista { get; set; }
        public List<Exposicion> ExposicionesObra { get; set; }
    }
}
