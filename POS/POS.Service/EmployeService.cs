using POS.Repository;
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
        public EmployeService (AppDbContext context) 
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
        public EmployeEntity View(int? id) 
        {
            var employe = _context.employes.Find(id);
            return employe;
        }
        public void Update(EmployeEntity employe) 
        {
            _context.employes.Update(employe);  
            _context.SaveChanges();
        }
        public void Delete(int? id) 
        {
            var employe = View(id);

            _context.employes.Remove(employe);  
            _context.SaveChanges();
        }
    }
}
