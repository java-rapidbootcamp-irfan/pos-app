using POS.Repository;
using POS.ViewModel;
using POS.ViewModel.Response;
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

        public OrdersService(AppDbContext context)
        {
            _context = context;
        }
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
            result.OrderDetails = new List<OrderDetailModel>();
            foreach(var item in entity.OrderDetails) 
            {
                result.OrderDetails.Add(EntityToModelOrderDetail(item));
            }
            return result;
        }

        private OrdersEntity ModelToEntity(OrdersModel model) 
        {
            var entity = new OrdersEntity();    
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
            entity.ShipPostalCode= model.ShipPostalCode;    
            entity.ShipCountry = model.ShipCountry;
            entity.OrderDetails = new List<OrderDetailEntity>();

            foreach(var item in model.OrderDetails) 
            {
             entity.OrderDetails.Add(ModelToEntityOrderDetail(item));            
            }

            return entity;

        }

        private OrderDetailModel EntityToModelOrderDetail(OrderDetailEntity entity) 
        {
            var result = new OrderDetailModel();    
            result.Id= entity.Id;
            result.ProductId= entity.ProductId; 
            result.UnitPrice= entity.UnitPrice;
            result.Quantity= entity.Quantity;   
            result.Discount= entity.Discount;

            return result;
        }

        private OrderDetailEntity ModelToEntityOrderDetail(OrderDetailModel model) 
        {
            var entity = new OrderDetailEntity();   
            entity.Id= model.Id;
            entity.ProductId= model.ProductId;  
            entity.UnitPrice= model.UnitPrice;
            entity.Quantity= model.Quantity;    
            entity.Discount= model.Discount;    

            return entity;
        }

        private DetailOfOrderResponse EntityToModelResponseDetail(OrdersEntity entity) 
        {
            var customer = _context.customers.Find(entity.CustomersId);

            var response = new DetailOfOrderResponse();
            response.Id = entity.Id;    
            response.CustomersId = entity.CustomersId;
            response.OrderDate = entity.OrderDate;
            response.RequiredDate = entity.RequiredDate;
            response.ShippedDate = entity.ShippedDate;
            response.ShipVia= entity.ShipVia;   
            response.Freight = entity.Freight;
            response.ShipName = entity.ShipName;
            response.ShipAddress = entity.ShipAddress;
            response.ShipCity = entity.ShipCity;
            response.ShipRegion = entity.ShipRegion;
            response.ShipPostalCode= entity.ShipPostalCode;
            response.ShipCountry = entity.ShipCountry;
            response.Details = new List<OrderDetailResponse>();

            foreach (var item in entity.OrderDetails) 
            {
                response.Details.Add(EntityToModelDetailResponse(item));
            }

            var subtotal = 0.0;
            foreach(var item in response.Details) 
            {
                item.Subtotal = item.Quantity * item.UnitPrice * (1- item.Discount / 100);
                subtotal += item.Subtotal;  
            }
            response.Subtotal = subtotal;
            response.Tax = 0.1 * subtotal;
            response.Shipping = 0;
            response.Total = response.Subtotal + response.Tax + response.Shipping;

            return response;
        }

        private OrderDetailResponse EntityToModelDetailResponse(OrderDetailEntity entity)
        {
            var model = new OrderDetailResponse();
            var product = _context.products.Find(entity.ProductId);

            model.Id = entity.Id;
            model.ProductId = product.Id;
            model.ProductName = product.ProductName;
            model.UnitPrice = entity.UnitPrice;
            model.Quantity = entity.Quantity;
            model.Discount = entity.Discount;

            return model;
        }

        public List<OrdersEntity> Get()
        {
            return _context.orders.ToList();
        }

        public void Add(OrdersModel newOrder)
        {
            var newData = ModelToEntity(newOrder);
            _context.orders.Add(newData);
            foreach (var item in newData.OrderDetails)
            {
                item.OrdersId = newOrder.Id;
                _context.orderDetails.Add(item);
            }
            _context.SaveChanges();
        }

        public OrdersModel View(int? id)
        {
            var order = _context.orders.Find(id);
            var detail = _context.orderDetails.Where(x => x.OrdersId == id);
            foreach (var item in detail) { }
            return EntityToModel(order);
        }

        public DetailOfOrderResponse ReadOrderInvoice(int? id)
        {
            var orderEntity = _context.orders.Find(id);
            var detailEntity = _context.orderDetails.Where(x => x.OrdersId == id).ToList();
            orderEntity.OrderDetails = detailEntity;
            var orderResponse = EntityToModelResponseDetail(orderEntity);
            return orderResponse;
        }

        public void Update(OrdersModel updatedOrder)
        {
            var entityOrder = _context.orders.Find(updatedOrder.Id);
            var orderDetailList = _context.orderDetails.Where(x => x.OrdersId == updatedOrder.Id).ToList();

            var updatedEntity = ModelToEntity(updatedOrder);

            entityOrder.CustomersId = updatedEntity.CustomersId;
            entityOrder.EmployeId = updatedEntity.EmployeId;
            entityOrder.OrderDate = updatedEntity.OrderDate;
            entityOrder.RequiredDate = updatedEntity.RequiredDate;
            entityOrder.ShippedDate = updatedEntity.ShippedDate;
            entityOrder.ShipVia = updatedEntity.ShipVia;
            entityOrder.Freight = updatedEntity.Freight;
            entityOrder.ShipName = updatedEntity.ShipName;
            entityOrder.ShipAddress = updatedEntity.ShipAddress;
            entityOrder.ShipCity = updatedEntity.ShipCity;
            entityOrder.ShipRegion = updatedEntity.ShipRegion;
            entityOrder.ShipPostalCode = updatedEntity.ShipPostalCode;
            entityOrder.ShipCountry = updatedEntity.ShipCountry;
            entityOrder.OrderDetails = updatedEntity.OrderDetails;

         

            _context.orders.Update(entityOrder);
            foreach (var newItem in entityOrder.OrderDetails)
            {
                newItem.OrdersId = updatedOrder.Id;
                foreach (var item in orderDetailList)
                {
                    if (newItem.ProductId == item.ProductId)
                    {
                        item.ProductId = newItem.ProductId;
                        item.UnitPrice = newItem.UnitPrice;
                        item.Quantity = newItem.Quantity;
                        item.Discount = newItem.Discount;
                        _context.orderDetails.Update(item);
                    }
                }

            }
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var order = _context.orders.Find(id);
            _context.orders.Remove(order);

            var detail = _context.orderDetails.Where(_x => _x.Id == id);
            foreach (var item in detail)
            {
                _context.orderDetails.Remove(item);
            }

            _context.SaveChanges();
        }
    }
}
