using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using watchShop.Entities;

namespace watchShop.Context
{
    public class WatchShopDBContext : IdentityDbContext<AppUser>
    {
        public WatchShopDBContext(DbContextOptions<WatchShopDBContext> options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedingCategory(modelBuilder);
            SeedingUsers(modelBuilder);
            SeedingRoles(modelBuilder);
            SeedingUserRoles(modelBuilder);
        }
        private void SeedingCategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Đồng hồ nam",
                    Description = "Đồng hồ nam",
                    Picture = "fas fa-alarm-clock",
                    Status = true
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Đồng hồ nữ",
                    Description = "Đồng hồ nữ",
                    Picture = "fas fa-alarm-clock",
                    Status = true
                });
        }
        private void SeedingUsers(ModelBuilder moduBuilder)
        {

        }
        private void SeedingRoles(ModelBuilder moduBuilder)
        {

        }
        private void SeedingUserRoles(ModelBuilder moduBuilder)
        {

        }
    }
}
