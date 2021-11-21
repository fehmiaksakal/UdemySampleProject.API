using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using UdemySampleProject.Core.Models;
using UdemySampleProject.Core.Repositories;

namespace UdemySampleProject.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public ProductRepository(DbContext context) : base(context)
        {
        }
        public async Task<Product> GetWithCategorybyIdAsync(int productId)
        {
            return await _appDbContext.Products.Include(x => x.Category)
                                                      .SingleOrDefaultAsync(x => x.Id == productId);
        }
    }
}
