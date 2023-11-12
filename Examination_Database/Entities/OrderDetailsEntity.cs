using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_Database.Entities
{
    internal class OrderDetailsEntity
    {
        [Key] public int Id { get; set; }

        public int PaymentId { get; set; }
        public PaymentsEntity Payment { get; set; } = null!;
        public int OrderId { get; set; }
        public OrdersEntity Order { get; set; } = null!;
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; } = null!;

        [Column(TypeName ="money")]
        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}
