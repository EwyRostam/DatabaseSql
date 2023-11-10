using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_Database.Entities;

internal class PaymentsEntity
{
    [Key] public int Id { get; set; }

    public DateTime OrderDate { get; set; } = DateTime.Now;
    public DateTime DueDate {  get; set; } = DateTime.Now.AddDays(30);

    [Column(TypeName = "money")]
    public decimal TotalSum { get; set; }
}
