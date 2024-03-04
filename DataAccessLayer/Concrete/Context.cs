using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-91LH8V7\\SQLEXPRESS;database=CoreETicaretDb2;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<HomePageFeature> HomePageFeatures { get; set; }
        public DbSet<ParentCategory> ParentCategories { get; set; }
        public DbSet<FeatureCategory> FeatureCategories { get; set; }
        public DbSet<BestSellingProduct> BestSellingProducts { get; set; }
        public DbSet<AboutService> AboutServices { get; set; }
        public DbSet<AboutBrands> AboutBrands { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany()
                .HasForeignKey(od => od.ProductId);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Cart>()
        //        .HasOne(c => c.Product)
        //        .WithMany()
        //        .HasForeignKey(c => c.ProductId);
        //}




    }

}

