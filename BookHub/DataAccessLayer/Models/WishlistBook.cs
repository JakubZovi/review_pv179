using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class WishlistBook : BaseEntity
{
    public int WishlistId { get; set; }
    
    [ForeignKey(nameof(WishlistId))]
    public virtual required Wishlist Wishlist { get; set; }
    
    public int BookId { get; set; }
    
    [ForeignKey(nameof(BookId))]
    public virtual required Book Book { get; set; }
}