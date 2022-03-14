using Duende.IdentityServer.EntityFramework.Options;
using EcommerceWeb.Server.Models;
using EcommerceWeb.Shared;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EcommerceWeb.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Condition> Conditions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seed Data Conditions
            builder.Entity<Condition>().HasData(
                new Condition() { ConditionId = 1, ConditionName = "A+" });
            builder.Entity<Condition>().HasData(
                new Condition() { ConditionId = 2, ConditionName = "A" });
            builder.Entity<Condition>().HasData(
                new Condition() { ConditionId = 3, ConditionName = "B+" });
            builder.Entity<Condition>().HasData(
                new Condition() { ConditionId = 4, ConditionName = "B" });
            builder.Entity<Condition>().HasData(
                new Condition() { ConditionId = 5, ConditionName = "C+" });
            builder.Entity<Condition>().HasData(
                new Condition() { ConditionId = 6, ConditionName = "C" });
            builder.Entity<Condition>().HasData(
                new Condition() { ConditionId = 7, ConditionName = "D+" });
            builder.Entity<Condition>().HasData(
                new Condition() { ConditionId = 8, ConditionName = "D" });
            builder.Entity<Condition>().HasData(
                new Condition() { ConditionId = 9, ConditionName = "E" });

            //Seed Data Products Gold Coin
            builder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    ProductCode = "",
                    Name = "",
                    Description = "",
                    Type = Types.Coin,
                    Metal = Metal.Gold,
                    MetalWeight = 0,
                    MetalBrand = "",
                    Weight = 0,
                    Condition = "",
                    Purify = 99.99,
                    Manufacture = "Nubex",
                    Certificate = "",
                    IsTax = true,
                    Featured = "",
                    Price = 0,
                    Color = "",
                    Size = 0,
                    ProductTag = "",
                    Image1 = "",
                    Image2 = "",
                    Image3 = "",
                    CreatedBy = "Administrators",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = ""
                });

            //Seed Data Products Gold Bar
            builder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 11,
                    ProductCode = "",
                    Name = "",
                    Description = "",
                    Type = Types.Bar,
                    Metal = Metal.Gold,
                    MetalWeight = 0,
                    MetalBrand = "",
                    Weight = 0,
                    Condition = "A+",
                    Purify = 99.99,
                    Manufacture = "Nubex",
                    Certificate = "",
                    IsTax = true,
                    Featured = "",
                    Price = 0,
                    Color = "",
                    Size = 0,
                    ProductTag = "",
                    Image1 = "",
                    Image2 = "",
                    Image3 = "",
                    CreatedBy = "Administrators",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = ""
                });

            //Seed Data Products Silver Coin
            builder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 21,
                    ProductCode = "",
                    Name = "",
                    Description = "",
                    Type = Types.Coin,
                    Metal = Metal.Silver,
                    MetalWeight = 0,
                    MetalBrand = "",
                    Weight = 0,
                    Condition = "A+",
                    Purify = 99.99,
                    Manufacture = "Nubex",
                    Certificate = "",
                    IsTax = true,
                    Featured = "",
                    Price = 0,
                    Color = "",
                    Size = 0,
                    ProductTag = "",
                    Image1 = "",
                    Image2 = "",
                    Image3 = "",
                    CreatedBy = "Administrators",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = ""
                });

            //Seed Data Products Silver Bar
            builder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 31,
                    ProductCode = "",
                    Name = "",
                    Description = "",
                    Type = Types.Bar,
                    Metal = Metal.Silver,
                    MetalWeight = 0,
                    MetalBrand = "",
                    Weight = 0,
                    Condition = "A+",
                    Purify = 99.99,
                    Manufacture = "Nubex",
                    Certificate = "",
                    IsTax = true,
                    Featured = "",
                    Price = 0,
                    Color = "",
                    Size = 0,
                    ProductTag = "",
                    Image1 = "",
                    Image2 = "",
                    Image3 = "",
                    CreatedBy = "Administrators",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = ""
                });
        }
    }
}