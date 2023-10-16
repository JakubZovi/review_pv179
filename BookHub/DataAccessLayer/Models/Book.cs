using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class Book : BaseEntity
{
    public int AuthorId { get; set; }
    
    [ForeignKey(nameof(AuthorId))]
    public virtual required Author Author { get; set; }
    
    public int PublisherId { get; set; }
    
    [ForeignKey(nameof(PublisherId))]
    public virtual required Publisher Publisher { get; set; }
    
    public int PriceId { get; set; }
    
    [ForeignKey(nameof(PriceId))]
    public virtual required Price Price { get; set; }
    
    public required string Name { get; set; }
    
    public required string Isbn { get; set; }
    
    public DateTime PublicationDate { get; set; }
    
    public required string Description { get; set; }
}