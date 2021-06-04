using KEK_Emlak.Data.Entities;
using KEK_Emlak.Data.Organize;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace KEK_Emlak.Repo
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserTypeMap(modelBuilder.Entity<UserType>());
            new CategoryMap(modelBuilder.Entity<Category>());
            new ProductMap(modelBuilder.Entity<Product>());
            new SellMap(modelBuilder.Entity<Sell>());
            new BuyMap(modelBuilder.Entity<Buy>());
            //new UserTypeMap(modelBuilder.Entity<UserType>());

        }
    }

}
