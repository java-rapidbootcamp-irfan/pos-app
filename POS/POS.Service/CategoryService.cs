using POS.Repository;
using POS.ViewModel;

namespace POS.Service
{
    public class CategoryService
    {
        private readonly AppDbContext _context;

        private CategoryModel EntityToModel(CategoryEntity entity) 
        {
            CategoryModel result= new CategoryModel();
            result.Id = entity.Id;  
            result.CategoryName= entity.CategoryName;   
            result.Description= entity.Description; 

            return result;  
        }

        private void ModelToEntity(CategoryModel model, CategoryEntity entity)
        {
            entity.CategoryName = model.CategoryName;
            entity.Description = model.Description;
        }

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
        public CategoryModel View(int? id)
        {
            var category = _context.categories.Find(id);
            return EntityToModel(category);
        }

        public void Update(CategoryModel category)
        {
            var entity = _context.categories.Find(category.Id);
            ModelToEntity(category, entity);
            _context.categories.Update(entity);
            _context.SaveChanges();

        }

        public void Delete(int? id)
        {
            var entity = _context.categories.Find(id);
            _context.categories.Remove(entity);
            _context.SaveChanges();
        }

    }
}