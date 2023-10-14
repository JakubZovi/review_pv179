namespace DefaultNamespace;

public class Wishlist:BaseEntity
{
    public string Name { get; set; }
    public int UserId { get; set; }
    public virtual? User User { get; set; }
    public List<WishlistBook> WishlistBooks { get; set; }
}