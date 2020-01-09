using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using gimc.Products.Dto;

namespace gimc.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<ProductDto> CreateProduct(ProductDto productDto);
        Task<ProductDto> GetProduct(int Id);
        Task<ListResultDto<ProductDto>> GetAllProducts();
        
    }
}
