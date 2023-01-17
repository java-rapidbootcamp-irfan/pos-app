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

        public ProductModel EntityToModel(ProductEntity entity)
        {
            ProductModel result = new ProductModel();
            result.Id = entity.Id;
            result.ProductName = entity.ProductName;
            result.SupplierId = entity.SupplierId;
            result.CategoryId = entity.CategoryId;
            result.QuantityPerUnit = entity.QuantityPerUnit;
            result.UnitPrice = entity.UnitPrice;
            result.UnitInStock = entity.UnitInStock;
            result.UnitOnOrder = entity.UnitOnOrder;
            result.ReorderLevel = entity.ReorderLevel;
            result.Discontinued = entity.Discontinued;

            return result;
        }

        public void ModelToEntity(ProductModel model, ProductEntity entity)
        {
            entity.ProductName = model.ProductName;
            entity.SupplierId = model.SupplierId;
            entity.CategoryId = model.CategoryId;
            entity.QuantityPerUnit = model.QuantityPerUnit;
            entity.UnitPrice = model.UnitPrice;
            entity.UnitInStock = model.UnitInStock;
            entity.UnitOnOrder = model.UnitOnOrder;
            entity.ReorderLevel = model.ReorderLevel;
            entity.Discontinued = model.Discontinued;
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

        public ProductModel View(int? id)
        {
            var product = _context.products.Find(id);
            return EntityToModel(product);
        }

        public void Update(ProductModel product)
        {
            var entity = _context.products.Find(product.Id);
            ModelToEntity(product, entity);
            _context.products.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var product = _context.products.Find(id);
            _context.products.Remove(product);
            _context.SaveChanges();
        }


    }
}