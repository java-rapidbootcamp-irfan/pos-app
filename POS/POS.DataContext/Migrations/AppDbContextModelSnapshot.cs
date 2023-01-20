﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POS.Repository;

#nullable disable

namespace POS.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("POS.Repository.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("POS.Repository.CustomersEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("company_name");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("contact_name");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("contact_title");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("country");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("fax");

                    b.Property<int>("Phone")
                        .HasColumnType("int")
                        .HasColumnName("phone");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int")
                        .HasColumnName("postal_code");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("region");

                    b.HasKey("Id");

                    b.ToTable("tbl_customers");
                });

            modelBuilder.Entity("POS.Repository.EmployeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("adress");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birth_date");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("country");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("extension");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("hire_date");

                    b.Property<int>("HomePhone")
                        .HasColumnType("int")
                        .HasColumnName("home_phone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("notes");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("photo_path");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int")
                        .HasColumnName("postal_code");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("region");

                    b.Property<string>("ReportsTo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("reports_to");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.Property<string>("TitleOfCourtesy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title_of_courtesy");

                    b.HasKey("Id");

                    b.ToTable("tbl_employe");
                });

            modelBuilder.Entity("POS.Repository.OrderDetailEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<double>("Discount")
                        .HasColumnType("double")
                        .HasColumnName("discount");

                    b.Property<int>("OrdersId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double")
                        .HasColumnName("unit_price");

                    b.HasKey("Id");

                    b.HasIndex("OrdersId");

                    b.HasIndex("ProductId");

                    b.ToTable("tbl_order_detail");
                });

            modelBuilder.Entity("POS.Repository.OrdersEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CustomersId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<int>("EmployeId")
                        .HasColumnType("int")
                        .HasColumnName("employe_id");

                    b.Property<int>("Freight")
                        .HasColumnType("int")
                        .HasColumnName("freight");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("order_date");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("required_date");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_address");

                    b.Property<string>("ShipCity")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_city");

                    b.Property<string>("ShipCountry")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_country");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_name");

                    b.Property<string>("ShipPostalCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_postal_code");

                    b.Property<string>("ShipRegion")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ship_region");

                    b.Property<int>("ShipVia")
                        .HasColumnType("int")
                        .HasColumnName("ship_via");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("shipped_date");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.HasIndex("EmployeId");

                    b.ToTable("tbl_orders");
                });

            modelBuilder.Entity("POS.Repository.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("discontinued");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("product_name");

                    b.Property<string>("QuantityPerUnit")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("quantity_per_unit");

                    b.Property<int>("ReorderLevel")
                        .HasColumnType("int")
                        .HasColumnName("reorder_level");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("supplier_id");

                    b.Property<int>("UnitInStock")
                        .HasColumnType("int")
                        .HasColumnName("unit_in_stock");

                    b.Property<int>("UnitOnOrder")
                        .HasColumnType("int")
                        .HasColumnName("unit_on_order");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double")
                        .HasColumnName("unit_price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("tbl_product");
                });

            modelBuilder.Entity("POS.Repository.SupplierEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("company_name");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("contact_name");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("contact_title");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("country");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("fax");

                    b.Property<string>("HomePage")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("home_page");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("phone");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int")
                        .HasColumnName("postal_code");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("region");

                    b.HasKey("Id");

                    b.ToTable("tbl_supplier");
                });

            modelBuilder.Entity("POS.Repository.OrderDetailEntity", b =>
                {
                    b.HasOne("POS.Repository.OrdersEntity", "Orders")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("POS.Repository.ProductEntity", "Product")
                        .WithMany("orderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("POS.Repository.OrdersEntity", b =>
                {
                    b.HasOne("POS.Repository.CustomersEntity", "Customers")
                        .WithMany("orders")
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("POS.Repository.EmployeEntity", "Employe")
                        .WithMany("orders")
                        .HasForeignKey("EmployeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("POS.Repository.ProductEntity", b =>
                {
                    b.HasOne("POS.Repository.CategoryEntity", "Category")
                        .WithMany("products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("POS.Repository.SupplierEntity", "Supplier")
                        .WithMany("products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("POS.Repository.CategoryEntity", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("POS.Repository.CustomersEntity", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("POS.Repository.EmployeEntity", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("POS.Repository.OrdersEntity", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("POS.Repository.ProductEntity", b =>
                {
                    b.Navigation("orderDetails");
                });

            modelBuilder.Entity("POS.Repository.SupplierEntity", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
