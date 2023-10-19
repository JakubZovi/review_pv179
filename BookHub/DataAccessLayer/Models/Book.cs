using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class Book : BaseEntity
{
    public virtual ICollection<Author> Author { get; set; } = null!;

    public virtual ICollection<Genre> Genres { get; set; } = null!;

    public virtual ICollection<Price> Prices { get; set; } = null!;

    public virtual ICollection<Wishlist> Wishlist { get; set; } = null!;

    public virtual ICollection<Rating> Ratings { get; set; } = null!;

    public virtual ICollection<PurchaseBook>? PurchaseBooks { get; set; }
    public int PublisherId { get; set; }

    [ForeignKey(nameof(PublisherId))] public virtual Publisher Publisher { get; set; } = null!;

    public required string Name { get; set; }

    public required string Isbn { get; set; }

    public DateTime PublicationDate { get; set; }

    public required string Description { get; set; }
}