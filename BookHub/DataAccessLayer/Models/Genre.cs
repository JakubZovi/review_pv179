namespace DataAccessLayer.Models;

public class Genre : BaseEntity
{
    public required string Name { get; set; }
    public virtual IEnumerable<GenreBook>? GenreBooks { get; set; }
}