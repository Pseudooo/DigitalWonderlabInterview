using System.ComponentModel.DataAnnotations;

namespace DigitalWonderlabInterview.Domain.Entities;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
}