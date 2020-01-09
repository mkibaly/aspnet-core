using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using gimc.Authorization.Users;
using gimc.Models;

namespace gimc.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto : EntityDto
    {
        public string VendorUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }

    }
}
