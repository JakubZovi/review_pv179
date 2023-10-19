using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class Rating : BaseEntity
{
    public int Stars { get; set; }

    public string? Review { get; set; }

    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))] public virtual User User { get; set; } = null!;

    public int BookId { get; set; }

    [ForeignKey(nameof(BookId))] public virtual Book Book { get; set; } = null!;
}