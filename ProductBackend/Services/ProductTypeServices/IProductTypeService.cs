using ProductBackend.Dtos;
using ProductBackend.Models;

namespace ProductBackend.Services.ProductTypeServices
{
    public interface IProductTypeService
    {
        Task<ServiceResponseDto<List<ProductType>>> GetProductTypes();
        Task<ServiceResponseDto<List<ProductType>>> AddProductType(ProductType productType);
        Task<ServiceResponseDto<List<ProductType>>> UpdateProductType(ProductType productType);
    }
}
