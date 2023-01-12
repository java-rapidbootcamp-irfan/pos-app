﻿using Microsoft.EntityFrameworkCore;
using POS.DataContext;

namespace POS.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> products => Set<ProductEntity>();
        public DbSet<CategoryEntity> categories => Set<CategoryEntity>();
        public DbSet<CustomerEntity> customers => Set<CustomerEntity>();
        public DbSet<EmployeEntity> employes => Set<EmployeEntity>();
        public DbSet<OrderDetailEntity> orderDetails => Set<OrderDetailEntity>();
        public DbSet<OrdersEntity> orders => Set<OrdersEntity>();
        public DbSet<SupplierEntity> suppliers => Set<SupplierEntity>();



    }
}