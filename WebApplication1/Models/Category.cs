using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Category
{
    [Key]
    public string? CategoryId { get; set; }
    [Required]
    public string? CategoryName { get; set; }
    public int DisplayOrder { get; set; }
}