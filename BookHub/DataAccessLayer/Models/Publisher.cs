namespace DataAccessLayer.Models;

public class Publisher : BaseEntity
{
    public required string Name { get; set; }

    public required string Address { get; set; }

    public virtual ICollection<Book> Books { get; set; } = null!;
}