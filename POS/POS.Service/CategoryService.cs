using POS.DataContext;
using POS.Repository;

namespace POS.Service
{
    public class CategoryService
    {
        private readonly ApplicationContext _context;
        public CategoryService(ApplicationContext context)
        {
            _context = context;
        }

        public List<CategoryEntity> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
