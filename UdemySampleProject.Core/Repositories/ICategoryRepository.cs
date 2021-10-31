using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemySampleProject.Core.Models;

namespace UdemySampleProject.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
    }
}
