using Examination_Database.Entities;
using Examination_Database.Models;
using Examination_Database.Repositories;
using System.Diagnostics;

namespace Examination_Database.Services;

internal class CategoryService
{
    private readonly CategoryRepository _categoryRepo;
    private readonly SubCategoryRepository _subCategoryRepo;

    public CategoryService(CategoryRepository categoryRepo, SubCategoryRepository subCategoryRepo)
    {
        _categoryRepo = categoryRepo;
        _subCategoryRepo = subCategoryRepo;
    }

    public async Task<CategoryEntity> CreateCategoryAsync(string categoryName)
    {
        try
        {
            var categoryEntity = await _categoryRepo.GetSpecificAsync(x => x.Name == categoryName);
            categoryEntity ??= await _categoryRepo.CreateAsync(new CategoryEntity { Name = categoryName });
            return categoryEntity;
        } catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public async Task<SubCategory> CreateSubCategoryAsync(string categoryName, string subCategoryName)
    {
        try
        {
            var primaryCategory = await CreateCategoryAsync(categoryName);

            var subCategoryEntity = await _subCategoryRepo.GetSpecificAsync(x => x.Name == subCategoryName);
            subCategoryEntity ??= await _subCategoryRepo.CreateAsync(new SubCategoryEntity { Name = subCategoryName });
            return subCategoryEntity;

        } catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return null!;
    }
}
