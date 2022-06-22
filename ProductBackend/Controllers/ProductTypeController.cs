using ProductBackend.Dtos;
using ProductBackend.Models;
using ProductBackend.Services.ProductTypeServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace ProductBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;

        public ProductTypeController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponseDto<List<ProductType>>>> GetProductTypes()
        {
            var response = await _productTypeService.GetProductTypes();
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponseDto<List<ProductType>>>> AddProductType(ProductType productType)
        {
            var response = await _productTypeService.AddProductType(productType);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponseDto<List<ProductType>>>> UpdateProductType(ProductType productType)
        {
            var response = await _productTypeService.UpdateProductType(productType);
            return Ok(response);
        }
    }
}
