
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Examination_Database.Entities;

internal class AdressEntity
{
    [Key] public int Id { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string StreetName { get; set; } = null!;

    [Column(TypeName = "varchar(6)")]
    public string? StreetNumber { get; set; }

    public int PostalCode { get; set; } 

    [Column(TypeName = "nvarchar(100)")]
    public string Country { get; set; } = null!;

    [Column(TypeName = "nvarchar(100)")]
    public string City { get; set; } = null!;
}
