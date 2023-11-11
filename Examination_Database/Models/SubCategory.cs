using Examination_Database.Entities;
using System.Diagnostics;

namespace Examination_Database.Models;

internal class SubCategory
{
    public int Id { get; set; }
    public string SubCategoryName { get; set; } = null!;
    public string CategoryName { get; set; } = null!;

    public static implicit operator SubCategory(SubCategoryEntity entity)
    {
        try
        {
            return new SubCategory
            {
                Id = entity.Id,
                SubCategoryName = entity.Name,
                CategoryName = entity.Category.Name
            };

        } catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

}
