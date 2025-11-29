using System.ComponentModel.DataAnnotations;
using Nikoll_Movies.DAL.Models;

namespace Nikoll_Movies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required(ErrorMessage = "El nombre de la película es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La duración es obligatoria")]
        public int Duration { get; set; } // en minutos

        [Required(ErrorMessage = "La clasificación es obligatoria")]
        [MaxLength(10, ErrorMessage = "La clasificación no puede exceder 10 caracteres")]
        public string Classification { get; set; } // PG, PG-13, R, etc.

        [MaxLength(500)]
        public string? Description { get; set; } // nullable

        [MaxLength(255)]
        public string? Director { get; set; } // nullable

        public int? ReleaseYear { get; set; } // nullable
    }
}