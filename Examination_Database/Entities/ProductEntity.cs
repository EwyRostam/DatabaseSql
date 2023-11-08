
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Examination_Database.Entities;

internal class ProductEntity
{
    
    [Key] public int Id { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string ArticleNumber { get; set; } = null!;

    [Column(TypeName = "varchar(50)")]
    public string Name { get; set; } = null!;

    [Column(TypeName = "varchar(200)")]
    public string? Description { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string? Color { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string? Brand { get; set; }

    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;
    public int StockId { get; set; }
    public StockEntity Stock { get; set; } = null!;

    public int SupplierId { get; set; }
    public SupplierEntity Supplier { get; set; } = null!;

  
}
