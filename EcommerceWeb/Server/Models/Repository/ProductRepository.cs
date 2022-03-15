﻿using EcommerceWeb.Server.Data;
using EcommerceWeb.Shared;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWeb.Server.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext appDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            this.appDbContext = applicationDbContext;
        }
        public async Task<Product> AddProduct(Product product)
        {
            var result = await appDbContext.Products

                .AddAsync(product);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Product> DeleteProduct(int productId)
        {
            //
            var result = await appDbContext.Products
                .FirstOrDefaultAsync(e => e.ProductId == productId);
            if (result != null)
            {
                appDbContext.Products.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Product?> GetProduct(int productId)
        {
            return await appDbContext.Products
                 .Include(e => e.Condition)
                 .Include(e => e.Metal)
                 .FirstOrDefaultAsync(e => e.ProductId == productId);
        }


        public async Task<Product> GetProductByName(string name)
        {
            return await appDbContext.Products
                .FirstOrDefaultAsync(e => e.Name.Contains(name));
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await appDbContext.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> SearchProduct(string name, Metal? metal)
        {
            //var 
            IQueryable<Product> query = appDbContext.Products;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Name.Contains(name) || e.Manufacture.Contains(name));
            }

            if (metal is not null)
            {
                query = query.Where(e => e.Metal == metal);
            }

            return await query.ToListAsync();
        }

        public Task<Product> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IProductRepository.GetProductByMetal(Metal? metal)
        {
            throw new NotImplementedException();
        }
    }
}