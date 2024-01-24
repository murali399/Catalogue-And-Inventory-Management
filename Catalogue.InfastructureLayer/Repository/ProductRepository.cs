using Catalogue.DomainLayer.Entity;
using Catalogue.DomainLayer.IReposistory;
using Catalogue.InfastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.InfastructureLayer.Reposistory
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext dbContext;

        public ProductRepository(ProductDbContext dbContext) 
        {
            this.dbContext = dbContext;
        } 
        /// <inheritdoc/>
        public  async Task<IEnumerable<Product>> GetAllProductAsync()
        {
          var product=  await dbContext.Products.ToListAsync();
          return product;

        }

        public  async Task<Product> GetProdcutByIdAsync(int id)
        {
            return await dbContext.Products.FirstOrDefaultAsync(x => x.ProdutcId == id);
        }

        public async Task<IEnumerable<Product>> GetProductByCategoryAsync(string category)
        {
            return await dbContext.Products.Where(p=> p.Category == category).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductBySubCategoryAsync(string subCategory)
        {
            return await dbContext.Products.Where(p => p.SubCategory == subCategory).ToListAsync();

        }
    }
}
