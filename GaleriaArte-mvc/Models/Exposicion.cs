using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GaleriaArte_mvc.Models
{
    public class Exposicion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Inicia")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        [DisplayName("Termina")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }
        public List<Obra> ObrasExpuestas { get; set; }
    }
}
