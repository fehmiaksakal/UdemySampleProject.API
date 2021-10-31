using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemySampleProject.Core.Models;

namespace UdemySampleProject.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetWithCategorybyIdAsync(int productId);
    }
}
