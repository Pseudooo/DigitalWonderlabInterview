using System.ComponentModel.DataAnnotations;

namespace DigitalWonderlabInterview.Domain.Entities.FilmEntity;

public class FilmEntity : BaseEntity
{
    [Required]
    public string Name { get; set; } = null!;
}

