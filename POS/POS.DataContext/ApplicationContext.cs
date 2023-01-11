using Microsoft.EntityFrameworkCore;
using POS.DataContext;

namespace POS.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products => Set<ProductEntity>();
        public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();
        public DbSet<CustomerEntity> Customers => Set<CustomerEntity>();
        public DbSet<EmployeEntity> Employes => Set<EmployeEntity>();
        public DbSet<OrderDetailEntity> OrderDetails => Set<OrderDetailEntity>();
        public DbSet<OrdersEntity> Orders => Set<OrdersEntity>();
        public DbSet<SupplierEntity> Suppliers => Set<SupplierEntity>();



    }
}