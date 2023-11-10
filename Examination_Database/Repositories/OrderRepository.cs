using Examination_Database.Contexts;
using Examination_Database.Entities;

namespace Examination_Database.Repositories
{
    internal class OrderRepository : Repo<OrdersEntity>
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
