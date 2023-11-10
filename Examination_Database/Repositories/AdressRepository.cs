using Examination_Database.Contexts;
using Examination_Database.Entities;

namespace Examination_Database.Repositories;

internal class AdressRepository : Repo<AdressEntity>
{
    private readonly DataContext _context;
    public AdressRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
