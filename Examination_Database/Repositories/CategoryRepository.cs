using Examination_Database.Contexts;
using Examination_Database.Entities;

namespace Examination_Database.Repositories;

internal class CategoryRepository : Repo<CategoryEntity>
{
    private readonly DataContext _context;
    public CategoryRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
