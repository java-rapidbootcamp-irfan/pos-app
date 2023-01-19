using POS.Repository;
using POS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Service
{
    public class EmployeService
    {
        private readonly AppDbContext _context;

        private EmployeModel EntityToModel(EmployeEntity entity) 
        {
            EmployeModel result = new EmployeModel();   
            result.Id = entity.Id;  
            result.LastName= entity.LastName;   
            result.FirstName= entity.FirstName;
            result.Title= entity.Title;
            result.TitleOfCourtesy= entity.TitleOfCourtesy; 
            result.BirthDate= entity.BirthDate; 
            result.HireDate= entity.HireDate;  
            result.Address= entity.Address;
            result.City= entity.City;   
            result.Region= entity.Region;   
            result.PostalCode= entity.PostalCode;
            result.Country= entity.Country; 
            result.HomePhone= entity.HomePhone; 
            result.Extension= entity.Extension; 
            result.Notes= entity.Notes; 
            result.ReportsTo= entity.ReportsTo; 
            result.PhotoPath= entity.PhotoPath; 

            return result;  
        }

        private void ModelToEntity(EmployeModel model, EmployeEntity entity) 
        {
            entity.LastName= model.LastName;    
            entity.FirstName= model.FirstName;  
            entity.Title= model.Title;  
            entity.TitleOfCourtesy= model.TitleOfCourtesy;  
            entity.BirthDate= model.BirthDate;  
            entity.HireDate = model.HireDate;   
            entity.Address= model.Address;
            entity.City= model.City;    
            entity.Region= model.Region;    
            entity.PostalCode= model.PostalCode;
            entity.Country= model.Country;  
            entity.HomePhone= model.HomePhone;
            entity.Extension= model.Extension;  
            entity.Notes= model.Notes;  
            entity.ReportsTo= model.ReportsTo;
            entity.PhotoPath= model.PhotoPath;
        }

        public EmployeService(AppDbContext context)
        {
            _context = context;
        }

        public List<EmployeEntity> Get()
        {
            return _context.employes.ToList();
        }

        public void Add(EmployeEntity employe)
        {
            _context.employes.Add(employe);
            _context.SaveChanges();
        }

        public EmployeModel View(int? id)
        {
            var employe = _context.employes.Find(id);
            return EntityToModel(employe);
        }

        public void Update(EmployeModel employe)
        {
            var entity = _context.employes.Find(employe.Id);
            ModelToEntity(employe, entity);
            _context.employes.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var entity = _context.employes.Find(id);
            _context.employes.Remove(entity);
            _context.SaveChanges();
        }


    }
}