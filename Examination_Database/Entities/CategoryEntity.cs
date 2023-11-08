using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_Database.Entities;

internal class CategoryEntity
{
    [Key] public int Id { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

    public int SubCategoryId { get; set; }
    public SubCategoryEntity? SubCategory { get; set; }

}
