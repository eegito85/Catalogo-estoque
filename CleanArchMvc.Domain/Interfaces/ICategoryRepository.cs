using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces.Base;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int? id);
        Task<Category> CreateCategoryAsync(Category category);
        Task<Category> UpdateCategoryAsync(Category category);
        Task<Category> RemoveCategoryAsync(Category category);
    }
}
