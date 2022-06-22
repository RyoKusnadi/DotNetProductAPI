using ProductBackend.Data;
using ProductBackend.Dtos;
using ProductBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductBackend.Services.ProductTypeServices
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly DataContext _context;

        public ProductTypeService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponseDto<List<ProductType>>> AddProductType(ProductType productType)
        {
            productType.Editing = productType.IsNew = false;
            _context.ProductTypes.Add(productType);
            await _context.SaveChangesAsync();

            return await GetProductTypes();
        }

        public async Task<ServiceResponseDto<List<ProductType>>> GetProductTypes()
        {
            var productTypes = await _context.ProductTypes.ToListAsync();
            return new ServiceResponseDto<List<ProductType>> { Data = productTypes };
        }

        public async Task<ServiceResponseDto<List<ProductType>>> UpdateProductType(ProductType productType)
        {
            var dbProductType = await _context.ProductTypes.FindAsync(productType.Id);
            if (dbProductType == null)
            {
                return new ServiceResponseDto<List<ProductType>>
                {
                    Success = false,
                    Message = "Product Type not found."
                };
            }

            dbProductType.Name = productType.Name;
            await _context.SaveChangesAsync();

            return await GetProductTypes();
        }
    }
}
