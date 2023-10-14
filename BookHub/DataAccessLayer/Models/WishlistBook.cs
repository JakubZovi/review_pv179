namespace DefaultNamespace;

public class WishlistBook:BaseEntity
{
    public int WishlistId { get; set; }
    public virtual Wishlist? Wishlist { get; set; }
    public int BookId { get; set; }
    public virtual Book? Book { get; set; }
    
}