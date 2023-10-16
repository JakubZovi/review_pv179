using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class Price : BaseEntity
{
    public int BookId { get; set; }
    
    [ForeignKey(nameof(BookId))]
    public virtual required Book Book { get; set; }
    
    public decimal PriceValue { get; set; }
    
    public required string Currency { get; set; }
    
    public DateTime Date { get; set; }
}