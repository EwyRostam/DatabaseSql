using Examination_Database.Contexts;
using Examination_Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Examination_Database.Repositories;

internal class ProductRepository : Repo<ProductEntity>
{
    private readonly DataContext _context;
    public ProductRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<ProductEntity> CreateAsync(ProductEntity entity)
    {
        try
        {
            var result = await base.CreateAsync(entity);
            var product = await _context.Products.Include(x => x.SubCategory).ThenInclude(x => x.Category).FirstOrDefaultAsync(x => x.Id == result.Id);
            return product ?? null!;
        
        } catch (Exception ex) { Debug.WriteLine(ex.Message); }
       
        return null!;
       
    }
}
