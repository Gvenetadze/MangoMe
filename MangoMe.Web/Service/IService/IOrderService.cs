using MangoMe.Web.Models;

namespace MangoMe.Web.Service.IService;

public interface IOrderService
{
    Task<ResponseDto?> CreateOrder(CartDto cartDto);
    Task<ResponseDto?> CreateStripeSession(StripeRequestDto stripeRequestDto);
    Task<ResponseDto?> ValidateStripeSession(int orderHeaderId);
}
