using POS.Repository;
using POS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Service
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        private ProductModel EntityToModel(ProductEntity entity) 
        {
            ProductModel result = new ProductModel();  
            result.ProductName= entity.ProductName;
            result.SupplierId= entity.SupplierId;   
            result.CategoryId= entity.CategoryId;   
            result.UnitPrice= entity.UnitPrice; 
            result.UnitInStock= entity.UnitInStock; 
            result.UnitOnOrder= entity.UnitOnOrder; 
            result.ReorderLevel= entity.ReorderLevel;   
            result.Discontinued= entity.Discontinued;

            return result;
        }

        private void ModelToEntity(ProductModel model, ProductEntity entity) 
        {

        }  

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public List<ProductEntity> Get()
        {
            return _context.products.ToList();
        }

        public void Add(ProductEntity product)
        {
            _context.products.Add(product);
            _context.SaveChanges();
        }

        public ProductEntity View(int? id)
        {
            var product = _context.products.Find(id);
            return product;
        }

        public void Update(ProductEntity product)
        {
            _context.products.Update(product);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var product = View(id);

            _context.products.Remove(product);
            _context.SaveChanges();
        }


    }
}