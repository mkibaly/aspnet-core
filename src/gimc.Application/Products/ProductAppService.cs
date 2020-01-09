using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Domain.Repositories;
using gimc.Products.Dto;
using gimc.Models;
using Abp.Application.Services.Dto;
using Microsoft.EntityFrameworkCore;

namespace gimc.Products
{
    public class ProductAppService : gimcAppServiceBase, IProductAppService
    {

        private readonly IRepository<Product> _ProductRepository;
        public ProductAppService(IRepository<Product> ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        public async Task<ListResultDto<ProductDto>> GetAllProducts()
        {
            var productList = await
                _ProductRepository
                .GetAll()
                .ToListAsync();

            return new ListResultDto<ProductDto>(
                ObjectMapper.Map<List<ProductDto>>(productList)
            );

        }

        public async Task<ProductDto> GetProduct(int Id)
        {
            var product = await
                _ProductRepository.GetAsync(Id);

            product.ViewCount++;

            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> CreateProduct(ProductDto productDto)
        {
            var inputProduct = ObjectMapper.Map<Product>(productDto);
            var product = await
                _ProductRepository.InsertAsync(inputProduct);

            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> UpdateProduct(ProductDto productDto)
        {
            var product = await
              _ProductRepository.GetAsync(productDto.Id);

            product.Title = productDto.Title;
            product.Description= productDto.Description;
            product.ImageUrl= productDto.ImageUrl;
            product.Price= productDto.Price;
            product.VendorUID= productDto.VendorUID;
            // privent editing view count
            // product.ViewCount = productDto.ViewCount;
            
            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<ProductDto>(product);

        }

        public async void DeleteProduct(int Id)
        {
            await _ProductRepository.DeleteAsync(Id);

            CurrentUnitOfWork.SaveChanges();

        }
    }
}
