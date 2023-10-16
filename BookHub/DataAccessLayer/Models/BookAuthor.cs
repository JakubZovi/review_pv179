using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class BookAuthor : BaseEntity
{
    public int AuthorId { get; set; }

    [ForeignKey(nameof(AuthorId))]
    public virtual required Author Author { get; set; }
    
    public int BookId { get; set; }
    
    [ForeignKey(nameof(BookId))]
    public virtual required Book Book { get; set; }
}