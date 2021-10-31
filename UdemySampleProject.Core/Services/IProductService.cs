using System.Threading.Tasks;
using UdemySampleProject.Core.Models;

namespace UdemySampleProject.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<Product> GetWithCategorybyIdAsync(int productId);
    }
}
