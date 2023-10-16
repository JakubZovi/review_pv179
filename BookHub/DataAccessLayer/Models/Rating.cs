using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class Rating: BaseEntity
{
    public int Stars { get; set; }
    
    public string? Review { get; set; }
    
    public int UserId { get; set; }
    
    [ForeignKey(nameof(UserId))]
    public virtual required User User { get; set; }
    
    public int BookId { get; set; }
    
    public virtual Book ?Book { get; set; }
    
}