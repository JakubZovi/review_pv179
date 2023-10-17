namespace DataAccessLayer.Models;

public class Author : BaseEntity
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public DateTime? DateOfDeath { get; set; }

    public DateTime DateOfBirth { get; set; }

    public virtual ICollection<Book> Books { get; set; } = null!;
}