using POS.DataContext;
using POS.Repository;

namespace POS.Service
{
    public class CategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public List<CategoryEntity> Get()
        {
            return _context.categories.ToList();
        }

        public void Add(CategoryEntity category)
        {
            _context.categories.Add(category);
            _context.SaveChanges();
        }
    }
}