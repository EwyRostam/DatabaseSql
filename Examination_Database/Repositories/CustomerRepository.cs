using Examination_Database.Contexts;
using Examination_Database.Entities;

namespace Examination_Database.Repositories;

internal class CustomerRepository : Repo<CustomerEntity>
{
    private readonly DataContext _context;
    public CustomerRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
