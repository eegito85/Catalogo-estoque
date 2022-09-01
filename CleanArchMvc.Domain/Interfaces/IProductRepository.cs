using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces.Base;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int? id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<Product> RemoveProductAsync(int id);
        Task<Product> GetProductCategoryAsync(int? id);
    }
}
