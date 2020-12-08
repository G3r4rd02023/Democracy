using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Democracy.Data.Entities
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [Required(ErrorMessage = "Debes ingresar una {0}")]
        [StringLength(30, ErrorMessage =
            "El campo {0} puede contener máximo {1} y mínimo {2} caráteres",
            MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
    }
}