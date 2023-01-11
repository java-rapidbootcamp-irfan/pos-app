using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }
        public DbSet<CategoryEntity> categoryEntities => Set<CategoryEntity>();
        public DbSet<ProductEntity> productEntities => Set<ProductEntity>();
        public DbSet<SupplierEntity> supplierEntities => Set<SupplierEntity>();
        public DbSet<OrderEntity> ordersEntities => Set<OrderEntity>();
        public DbSet<CustomersEntity> customersEntities => Set<CustomersEntity>();
        public DbSet<OrderDetailEntity> orderDetailEntities => Set<OrderDetailsEntity>();
        public DbSet<EmployeEntity> employeEntities => Set<EmployeEntity>();

    }
}