using System.ComponentModel.DataAnnotations;

public class MovieCreateUpdateDto
{
    [Required(ErrorMessage = "El nombre de la película es obligatorio")]
    [MaxLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
    public string Name { get; set; }

    [Required(ErrorMessage = "La duración es obligatoria")]
    public int Duration { get; set; }

    [Required(ErrorMessage = "La clasificación es obligatoria")]
    [MaxLength(10, ErrorMessage = "La clasificación no puede exceder 10 caracteres")]
    public string Classification { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    [MaxLength(255)]
    public string? Director { get; set; }

    public int? ReleaseYear { get; set; }
}
