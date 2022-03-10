using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces.Base;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<Product> GetProductCategoryAsync(int? id);
    }
}
