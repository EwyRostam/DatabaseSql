using Examination_Database.Entities;
using System.Diagnostics;

namespace Examination_Database.Models;

internal class Category
{
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;

    public static implicit operator Category(CategoryEntity entity)
    {
        try
        {
            return new Category
            {
                Id = entity.Id,
                CategoryName = entity.Name
            };

        } catch (Exception ex) { Debug.WriteLine(ex.Message);
            return null!;
    }
}
