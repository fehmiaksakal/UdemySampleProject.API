using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using UdemySampleProject.Core.Models;
using UdemySampleProject.Core.Repositories;

namespace UdemySampleProject.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return await _appDbContext.Categpries.Include(x => x.Products)
                                                 .SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}
