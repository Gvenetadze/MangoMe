using AutoMapper;
using MangoMe.Services.ProductAPI.Models;
using MangoMe.Services.ProductAPI.Models.Dtos;

namespace MangoMe.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration( config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
