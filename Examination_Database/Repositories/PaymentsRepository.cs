using Examination_Database.Contexts;
using Examination_Database.Entities;

namespace Examination_Database.Repositories
{
    internal class PaymentsRepository : Repo<PaymentsEntity>
    {
        private readonly DataContext _context;
        public PaymentsRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
