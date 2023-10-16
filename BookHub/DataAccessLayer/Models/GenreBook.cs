using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class GenreBook : BaseEntity
{
    public int BookId { get; set; }
    
    [ForeignKey(nameof(BookId))]
    public virtual required Book Book { get; set; }
    
    public int GenreId { get; set; }
    
    [ForeignKey(nameof(GenreId))]
    public virtual required Genre Genre { get; set; }
}