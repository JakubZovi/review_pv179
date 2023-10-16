namespace DataAccessLayer.Models;

public class Publisher : BaseEntity
{
    public required string Name { get; set; }
    
    public required string Email { get; set; }
    
    public virtual ICollection<Book>? Books { get; set; }
    
}