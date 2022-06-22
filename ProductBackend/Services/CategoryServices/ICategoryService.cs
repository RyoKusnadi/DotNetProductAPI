using ProductBackend.Dtos;
using ProductBackend.Models;

namespace ProductBackend.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<ServiceResponseDto<List<Category>>> GetCategories();
        Task<ServiceResponseDto<List<Category>>> GetAdminCategories();
        Task<ServiceResponseDto<List<Category>>> AddCategory(Category category);
        Task<ServiceResponseDto<List<Category>>> UpdateCategory(Category category);
        Task<ServiceResponseDto<List<Category>>> DeleteCategory(int id);
    }
}
