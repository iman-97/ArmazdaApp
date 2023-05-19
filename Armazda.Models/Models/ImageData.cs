using System.ComponentModel.DataAnnotations;

namespace Armazda.Models.Models;

public class ImageData
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? VideoLink { get; set; }
    [Required]
    public byte[]? Image { get; set; }
}
