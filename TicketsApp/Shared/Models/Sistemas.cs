using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Sistemas
    {
        [Key]
        public int SistemaId { get; set; }
        [Required(ErrorMessage = "Es requerido")]
        public string? Nombre { get; set; }
    }
}
