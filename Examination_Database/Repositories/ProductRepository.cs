using Examination_Database.Contexts;
using Examination_Database.Entities;

namespace Examination_Database.Repositories;

internal class ProductRepository : Repo<ProductEntity>
{
    private readonly DataContext _context;
    public ProductRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
