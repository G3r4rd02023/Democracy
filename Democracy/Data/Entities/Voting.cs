using System;
using System.ComponentModel.DataAnnotations;

namespace Democracy.Data.Entities
{
    public class Voting
    {
        [Key]
        public int VotingId { get; set; }

        [Required(ErrorMessage = "Debes ingresar una {0}")]
        [StringLength(30, ErrorMessage =
            "El campo {0} puede contener máximo {1} y mínimo {2} caráteres",
            MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        public int StateId { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Display(Name = "Inicio")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateTimeStart { get; set; }

        [Display(Name = "Final")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateTimeEnd { get; set; }

        [Display(Name = "Es para todos?")]
        public bool IsForAllUsers { get; set; }

        [Display(Name = "Votos en Blanco?")]
        public bool IsEnabledBlankVote { get; set; }

        [Display(Name = "Cantidad de Votos")]
        public int QuantityVotes { get; set; }

        [Display(Name = "Votos en Blanco")]
        public int QuantityBlankVotes { get; set; }

        [Display(Name = "Ganador")]
        public int CandidateWin { get; set; }

        public virtual State State { get; set; }

    }
}