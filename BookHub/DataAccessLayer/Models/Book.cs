using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class Book : BaseEntity
{
    public ICollection<Author> Author { get; set; }

    public ICollection<Genre> Genres { get; set; }

    public ICollection<Price> Prices { get; set; }

    public ICollection<Wishlist> Wishlist { get; set; }

    public ICollection<Rating> Ratings { get; set; }

    public ICollection<PurchaseBook> PurchaseBooks { get; set; }
    public int PublisherId { get; set; }

    [ForeignKey(nameof(PublisherId))] public virtual required Publisher Publisher { get; set; }

    public required string Name { get; set; }

    public required string Isbn { get; set; }

    public DateTime PublicationDate { get; set; }

    public required string Description { get; set; }
}