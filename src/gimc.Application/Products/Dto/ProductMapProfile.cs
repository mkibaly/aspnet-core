using AutoMapper;
using gimc.Authorization.Users;
using gimc.Models;

namespace gimc.Products.Dto
{
    public class ProductMapProfile : Profile
    {
        public ProductMapProfile()
        {
            CreateMap<ProductDto, Product>();
            CreateMap<ProductDto, Product>()
                .ForMember(x => x.DietaryFlags, opt => opt.Ignore());
             
        }
    }
}
