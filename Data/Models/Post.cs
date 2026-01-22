using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestProject.Data.Models;

[Table("Post")]
public class Post
{
    [Key]
    public int Id {get; set;}
    public string ImageUrl { get; set; } = null!;
    public string? Caption { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int UserId { get; set; }
    public User User { get; set; } = null!;
    
}