using System.ComponentModel.DataAnnotations;

namespace Examination_Database.Entities;

internal class OrdersEntity
{
    [Key] public int Id { get; set; }

    public int ProductId { get; set; }
    public ProductEntity? Product { get; set; }

    public int CustomerId { get; set; }
    public CustomerEntity Customer { get; set; } = null!;
    public int OrderDetailId { get; set; }
    public OrderDetailsEntity OrderDetail { get; set; } = null!;
}
