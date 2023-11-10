using System.ComponentModel.DataAnnotations;

namespace Examination_Database.Entities;

internal class StockEntity
{
    [Key] public int Id { get; set; }

    public int ProductId { get; set; }
    public ProductEntity Product { get; set; } = null!;
    public int Quantity { get; set; }
}
