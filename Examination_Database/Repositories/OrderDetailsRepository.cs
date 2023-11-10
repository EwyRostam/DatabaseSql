using Examination_Database.Contexts;
using Examination_Database.Entities;

namespace Examination_Database.Repositories;

internal class OrderDetailsRepository : Repo<OrderDetailsEntity>
{
    private readonly DataContext _context;
    public OrderDetailsRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
