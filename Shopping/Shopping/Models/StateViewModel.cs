﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Shopping.Models
{
    public class StateViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Departamento/Estado")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracterés")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }

        public int CountryId { get; set; }
    }
}