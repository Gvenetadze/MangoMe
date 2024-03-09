using AutoMapper;
using MangoMe.Services.CouponAPI.Models;
using MangoMe.Services.CouponAPI.Models.Dto;

namespace MangoMe.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration( config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }

    }
}
