using Examination_Database.Contexts;
using Examination_Database.Entities;

namespace Examination_Database.Repositories;

internal class SupplierRepository : Repo<SupplierEntity>
{
    private readonly DataContext _context;
    public SupplierRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
