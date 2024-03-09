using MangoMe.Web.Models;

namespace MangoMe.Web.Service.IService;

public interface ICartService
{
    Task<ResponseDto?> GetCartByUserIdAsync(string UserId);
    Task<ResponseDto?> UpsertCartAsync(CartDto cartDto);
    Task<ResponseDto?> RemoveFromCartAsync(int cartDetailsId);
    Task<ResponseDto?> ApplyCouponAsync(CartDto cartDto);
    Task<ResponseDto?> EmailCart(CartDto cartDto);

}
