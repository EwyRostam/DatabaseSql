using Examination_Database.Contexts;
using Examination_Database.Entities;

namespace Examination_Database.Repositories
{
    internal class SubCategoryRepository : Repo<SubCategoryEntity>
    {
        private readonly DataContext _context;
        public SubCategoryRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
