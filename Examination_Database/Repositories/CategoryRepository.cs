using Examination_Database.Contexts;
using Examination_Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Examination_Database.Repositories;

internal class CategoryRepository : Repo<CategoryEntity>
{
    private readonly DataContext _context;
    public CategoryRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<CategoryEntity>> GetAllAsync()
    {
        var result = await _context.Categories.Include(x => x.SubCategories).ToListAsync();
        return result;
    }
}
