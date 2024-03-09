using AutoMapper;
using MangoMe.Services.OrderAPI.Models;
using MangoMe.Services.OrderAPI.Models.Dto;


namespace MangoMe.Services.OrderAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<OrderHeaderDto, CartHeaderDto>()
                .ForMember(dest => dest.CartTotal, u => u.MapFrom(src => src.OrderTotal)).ReverseMap();

                config.CreateMap<CartDetailsDto, OrderDetailsDto>()
                .ForMember(dest => dest.ProductName, u => u.MapFrom(src => src.Product.Name))
                .ForMember(dest => dest.Price, u => u.MapFrom(src => src.Product.Price));

                config.CreateMap<OrderDetailsDto, CartDetailsDto>();

                config.CreateMap<OrderHeader, OrderHeaderDto>().ReverseMap();
                config.CreateMap<OrderDetailsDto, OrderDetails>().ReverseMap();
            });
            return mappingConfig;
        }
        //public static MapperConfiguration RegisterMaps()
        //{
        //    var mappingConfig = new MapperConfiguration(config =>
        //    {
        //        config.CreateMap<OrderHeaderDto, CartHeaderDto>()
        //            .ForMember(dest => dest.CartTotal, u => u.MapFrom(src => src.OrderTotal))
        //            .ReverseMap();

        //        config.CreateMap<CartDetailsDto, OrderDetailsDto>()
        //            .ForMember(dest => dest.Product, u => u.MapFrom(src => new ProductDto
        //            {
        //                Name = src.Product.Name,
        //                Price = src.Product.Price
        //            }));

        //        config.CreateMap<OrderDetailsDto, CartDetailsDto>();

        //        config.CreateMap<OrderHeader, OrderHeaderDto>().ReverseMap();
        //        config.CreateMap<OrderDetailsDto, OrderDetails>().ReverseMap();
        //    });
        //    return mappingConfig;
        //}

    }
}
