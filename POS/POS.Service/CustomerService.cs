using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using POS.Repository;
using POS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Service
{
    public class CustomerService
    {
        private readonly AppDbContext _context;
        private CustomerModel EntityToModel(CustomerEntity entity)
        {
            CustomerModel result = new CustomerModel();
            result.Id = entity.Id;
            result.CompanyName = entity.CompanyName;
            result.ContactName = entity.ContactName;
            result.ContactTitle= entity.ContactTitle;
            result.Address = entity.Address;
            result.City = entity.City;
            result.Region = entity.Region;
            result.PostalCode = entity.PostalCode;
            result.Country = entity.Country;
            result.Phone = entity.Phone;
            result.Fax = entity.Fax;

            return result;
        }

        private void ModelToEntity(CustomerModel model, CustomerEntity entity)
        {
            entity.CompanyName= model.CompanyName;
            entity.ContactName= model.ContactName;
            entity.ContactTitle= model.ContactTitle;
            entity.Address= model.Address;
            entity.City= model.City;
            entity.Region= model.Region;
            entity.PostalCode= model.PostalCode;
            entity.Country= model.Country;
            entity.Phone= model.Phone;
            entity.Fax= model.Fax;
        }
       
        public CustomerService(AppDbContext context)
        {
            _context=context;
        }

        public List<CustomerEntity> Get() 
        {
            return _context.customers.ToList(); 
        }

        public void Add(CustomerEntity customer)
        {
            _context.customers.Add(customer);
            _context.SaveChanges();
        }
        public CustomerModel View(int? id) 
        {
            var customer = _context.customers.Find(id);
            return EntityToModel(customer);
        }

        public void Update(CustomerModel customer) 
        {
            var entity = _context.customers.Find(customer.Id);
            ModelToEntity(customer, entity);
            _context.customers.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(int? id) 
        {
            var customer = View(id);

            var entity = _context.customers.Find(id);
            _context.customers.Remove(entity);
            _context.SaveChanges();
        }
    }
}
