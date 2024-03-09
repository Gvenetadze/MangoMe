using AutoMapper;
using MangoMe.Services.ShoppingCartAPI.Models;
using MangoMe.Services.ShoppingCartAPI.Models.Dtos;

namespace MangoMe.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration( config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>();
                config.CreateMap<CartHeaderDto, CartHeader>();
                config.CreateMap<CartDetails, CartDetailsDto>();
                config.CreateMap<CartDetailsDto, CartDetails>();
            });
            return mappingConfig;
        }
    }
}
