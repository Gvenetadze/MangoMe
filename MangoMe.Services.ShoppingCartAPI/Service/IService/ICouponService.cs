using MangoMe.Services.ShoppingCartAPI.Models.Dto;
using MangoMe.Services.ShoppingCartAPI.Models.Dtos;

namespace MangoMe.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
