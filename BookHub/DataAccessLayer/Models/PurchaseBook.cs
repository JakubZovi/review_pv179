using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class PurchaseBook : BaseEntity
{
    public int BookId { get; set; }

    [ForeignKey(nameof(BookId))] public virtual Book Book { get; set; } = null!;

    public int PurchaseId { get; set; }

    [ForeignKey(nameof(PurchaseId))] public virtual Purchase Purchase { get; set; } = null!;

    public decimal Price { get; set; }
}