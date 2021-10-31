using System.Threading.Tasks;
using UdemySampleProject.Core.Models;

namespace UdemySampleProject.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
    }
}
