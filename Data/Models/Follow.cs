using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Data.Models;

[Table("Follow")]
public class Follow
{
    [Key]
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Required]
    public Guid FollowerId { get; set; }

    [ForeignKey(nameof(FollowerId))]
    public User Follower { get; set; } = null!;

    [Required]
    public Guid FollowingId { get; set; }

    [ForeignKey(nameof(FollowingId))]
    public User Following { get; set; } = null!;
}
