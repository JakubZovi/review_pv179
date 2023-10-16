using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class Purchase : BaseEntity
{
    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual required User User { get; set; }

    public DateTime Date { get; set; }
}