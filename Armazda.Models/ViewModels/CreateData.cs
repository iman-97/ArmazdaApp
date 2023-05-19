using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Armazda.Models.ViewModels;

public class CreateData
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? VideoLink { get; set; }
    [Required]
    public IFormFile? Image { get; set; }
}
