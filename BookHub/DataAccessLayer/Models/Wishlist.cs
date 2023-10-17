using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class Wishlist : BaseEntity
{
    public required string Name { get; set; }
     
    public int UserId { get; set; }
    
    [ForeignKey(nameof(UserId))]
    public virtual User User { get; set; } = null!;
    
    public virtual ICollection<Book> Books { get; set; } = null!;
}