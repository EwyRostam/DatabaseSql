using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_Database.Entities;

internal class SubCategoryEntity
{
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;
     //Hash-set is a List only shows similar values ones, if they exist in a larger quantity
    public ICollection<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>();
}
