using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Shared.Models
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [ForeignKey("Clientes")]
        public int ClienteId { get; set; }

        [ForeignKey("Sistemas")]
        public int SistemaId { get; set; }

        [ForeignKey("Prioridades")]
        public int PriodidadID { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? SolicitadoPor { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? Asunto { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? Descripcion { get; set; }

        [ForeignKey("TicketId")]
        public ICollection<Tickets_Detalle> Detalle { get; set; } = new List<Tickets_Detalle>();

    }
}
