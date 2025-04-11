using API.Data;
using Microsoft.EntityFrameworkCore;
using WebsiteBanHang.Entities;

namespace API.Repositories.Contracts
{
    public class ProductRepository : IProductRepository
    {
        private readonly BHDbContext _dbContext;
        public ProductRepository(BHDbContext dbContext)
        {
            _dbContext = dbContext; 
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await _dbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await _dbContext.Products.ToListAsync();
            return products;
        }
    }
}
