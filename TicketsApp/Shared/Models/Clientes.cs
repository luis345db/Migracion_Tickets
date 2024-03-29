﻿using System.ComponentModel.DataAnnotations;


namespace Shared.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string RNC { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string Email { get; set; }

        public string Direccion { get; set; }
    }
}
