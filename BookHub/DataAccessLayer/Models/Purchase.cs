using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models;

public class Purchase : BaseEntity
{
    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))] public virtual User User { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual List<PurchaseBook> PurchaseBooks { get; set; } = null!;
}