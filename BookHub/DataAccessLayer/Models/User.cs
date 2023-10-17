namespace DataAccessLayer.Models;

public class User : BaseEntity
{
    public required string FirstName { get; set; }
    
    public required string LastName { get; set; }
    
    public string? Gender { get; set; }
    
    public required string Email { get; set; }
    
    public required string PasswordHash { get; set; }
    
    public bool IsAdmin { get; set; }

    public virtual ICollection<Rating> Ratings { get; set; } = null!;
    public virtual ICollection<Purchase> Purchases { get; set; } = null!;
}