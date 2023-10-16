using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class PurchaseBook
{
    public int BookId { get; set; }
    
    [ForeignKey(nameof(BookId))]
    public virtual required Book Book { get; set; }
    
    public int PurchaseId { get; set; }
    
    [ForeignKey(nameof(PurchaseId))]
    public virtual required Purchase Purchase { get; set; } 
    
    
}