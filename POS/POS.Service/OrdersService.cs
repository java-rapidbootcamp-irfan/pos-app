using POS.Repository;
using POS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Service
{
    public class OrdersService
    {
        private readonly AppDbContext _context;
        private OrdersModel EntityToModel(OrdersEntity entity)
        {
            OrdersModel result = new OrdersModel();
            result.Id = entity.Id;
            result.CustomersId = entity.CustomersId;
            result.EmployeId = entity.EmployeId;
            result.OrderDate = entity.OrderDate;
            result.RequiredDate= entity.RequiredDate;
            result.ShippedDate = entity.ShippedDate;
            result.ShipVia = entity.ShipVia;
            result.Freight = entity.Freight;
            result.ShipName = entity.ShipName;
            result.ShipAddress = entity.ShipAddress;
            result.ShipCity = entity.ShipCity;
            result.ShipRegion = entity.ShipRegion;
            result.ShipPostalCode = entity.ShipPostalCode;
            result.ShipCountry = entity.ShipCountry;
            return result;
        }

        private void ModelToEntity(OrdersModel model, OrdersEntity entity)
        {
            entity.CustomersId = model.CustomersId;
            entity.EmployeId = model.EmployeId;
            entity.OrderDate = model.OrderDate;
            entity.RequiredDate = model.RequiredDate;
            entity.ShippedDate = model.ShippedDate;
            entity.ShipVia = model.ShipVia;
            entity.Freight = model.Freight;
            entity.ShipName = model.ShipName;
            entity.ShipAddress = model.ShipAddress;
            entity.ShipCity = model.ShipCity;
            entity.ShipRegion = model.ShipRegion;
            entity.ShipPostalCode = model.ShipPostalCode;
            entity.ShipCountry = model.ShipCountry;
        }

        public OrdersService(AppDbContext context)
        {
            _context = context;
        }

        public List<OrdersEntity> Get()
        {
            return _context.orders.ToList();
        }

        public void Add(OrdersEntity orders)
        {
            _context.orders.Add(orders);
            _context.SaveChanges();
        }

        public OrdersModel View(int? id)
        {
            var orders = _context.orders.Find(id);
            return EntityToModel(orders);
        }

        public void Update(OrdersModel orders)
        {
            var entity = _context.orders.Find(orders.Id);
            ModelToEntity(orders, entity);
            _context.orders.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var entity = _context.orders.Find(id);
            _context.orders.Remove(entity);
            _context.SaveChanges();
        }
    }
}