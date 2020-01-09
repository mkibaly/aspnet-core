using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;
using Abp.Application.Services.Dto;
using gimc.Products;
using gimc.Products.Dto;

namespace gimc.Tests.Products
{
    public class ProductAppService_Tests : gimcTestBase
    {
        private readonly IProductAppService _productAppService;

        public ProductAppService_Tests()
        {
            _productAppService = Resolve<IProductAppService>();
        }

        [Fact]
        public async Task CreateProduct_Test()
        {
            // Act
            await _productAppService.CreateProduct(
                new ProductDto
                {
                    Title = "Test prduct",
                    Description = "this is a test description",
                    ImageUrl = "https://imagecdn.com/image.jpg",
                    Price = 33.83,
                    VendorUID = "JU97"
                });

            await UsingDbContextAsync(async context =>
            {
                var johnNashUser = await context.Products.FirstOrDefaultAsync(p => p.Title == "Test prduct");
                johnNashUser.ShouldNotBeNull();
            });
        }


        [Fact]
        public async Task GetAllProducts_Test()
        {
            // Act
            var output = await _productAppService.GetAllProducts( );

            // Assert
            output.Items.Count.ShouldBe(1);
        }

    }
}
