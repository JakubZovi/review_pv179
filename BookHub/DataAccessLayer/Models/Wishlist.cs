using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class Wishlist : BaseEntity
{
    public required string Name { get; set; }
     
    public int UserId { get; set; }
    
    [ForeignKey(nameof(UserId))]
    public virtual required User User { get; set; }
    
    public List<Book>? Books { get; set; }
}