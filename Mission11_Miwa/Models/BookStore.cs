using System.ComponentModel.DataAnnotations;

namespace Mission11_Miwa.Models;

public class BookStore
{
    [Key]
    [Required]
    public int BookId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Author { get; set; }
    [Required]
    public string Publisher { get; set; }
    [Required]
    public string Isbn { get; set; }
    [Required]
    public string Classification { get; set; }
    [Required]
    public string Category { get; set; }
    [Required]
    public int PageCount { get; set; }
    [Required]
    public float Price { get; set; }
}