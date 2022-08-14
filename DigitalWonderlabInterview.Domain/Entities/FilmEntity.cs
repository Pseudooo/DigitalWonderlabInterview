using System.ComponentModel.DataAnnotations;

namespace DigitalWonderlabInterview.Domain.Entities;

public class FilmEntity : BaseEntity
{
    [Required]
    public string Name { get; set; } = null!;
    public int Rating { get; set; }
}

