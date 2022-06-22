using ProductBackend.Dtos;
using ProductBackend.Models;

namespace ProductBackend.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponseDto<List<Product>>> GetProductsAsync();
        Task<ServiceResponseDto<Product>> GetProductAsync(int productId);
        Task<ServiceResponseDto<List<Product>>> GetProductsByCategory(string categoryUrl);
        Task<ServiceResponseDto<ProductSearchResult>> SearchProducts(string searchText, int page);
        Task<ServiceResponseDto<List<string>>> GetProductSearchSuggestions(string searchText);
        Task<ServiceResponseDto<List<Product>>> GetFeaturedProducts();
        Task<ServiceResponseDto<List<Product>>> GetAdminProducts();
        Task<ServiceResponseDto<Product>> CreateProduct(Product product);
        Task<ServiceResponseDto<Product>> UpdateProduct(Product product);
        Task<ServiceResponseDto<bool>> DeleteProduct(int productId);
    }
}
