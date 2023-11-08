using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_Database.Entities;

internal class SubCategoryEntity
{
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

}
