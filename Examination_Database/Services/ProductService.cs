using Examination_Database.Entities;
using Examination_Database.Models;
using Examination_Database.Repositories;

namespace Examination_Database.Services;

internal class ProductService
{
    private readonly ProductRepository _productRepo;
    private readonly SubCategoryRepository _subCategoryRepo;

    public ProductService(ProductRepository productRepo, SubCategoryRepository subCategoryRepo)
    {
        _productRepo = productRepo;
        _subCategoryRepo = subCategoryRepo;
    }

    public async Task<Product> CreateProductAsync(ProductRegistration registration)
    {
        var item = await _productRepo.GetSpecificAsync(x => x.ArticleNumber == registration.ArticleNumber);
        if (item == null)
        {
            var entity = new ProductEntity
            {
                ArticleNumber = registration.ArticleNumber,
                Name = registration.Name,
                Description = registration.Description,
                StockPrice = registration.Price,
                SubCategoryId = (await _subCategoryRepo.GetSpecificAsync(x => x.Name == registration.SubCategory)).Id
            };

            entity = await _productRepo.CreateAsync(entity);

            var product = new Product
            {
                ArticleNumber = entity.ArticleNumber,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.StockPrice,
                SubCategory = entity.SubCategory.Name,
                PrimaryCategory = entity.SubCategory.Category.Name
            };

            return product;


        }

        return null!;
    }
}
