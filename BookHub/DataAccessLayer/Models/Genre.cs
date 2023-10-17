namespace DataAccessLayer.Models;

public class Genre : BaseEntity
{
    public required string Name { get; set; }
    public virtual ICollection<Book> Books { get; set; } = null!;
}