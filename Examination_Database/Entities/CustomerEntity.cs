using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_Database.Entities;

[Index(nameof(Email), IsUnique = true)]
internal class CustomerEntity
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string FirstName { get; set; } = null!;

    [Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; } = null!;

    [Column(TypeName = "nvarchar(50)")]
    public string Email { get; set; } = null!;

    [Column(TypeName = "varchar(12)")]
    public string Phonenumber { get; set; } = null!;

    public int AdressId { get; set; }
    public AdressEntity Adress { get; set; } = null!;

    public int PaymentId { get; set; }
    public PaymentsEntity Payment { get; set; } = null!;

}
