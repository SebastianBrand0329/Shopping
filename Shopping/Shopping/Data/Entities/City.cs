﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Shopping.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracterés")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }

        public State State { get; set; }


    }
}
