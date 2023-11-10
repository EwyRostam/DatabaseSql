using Examination_Database.Contexts;
using Examination_Database.Entities;

namespace Examination_Database.Repositories;

internal class StockRepository : Repo<StockEntity>
{
    private readonly DataContext _context;
    public StockRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
