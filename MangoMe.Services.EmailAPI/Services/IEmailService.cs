using MangoMe.Services.EmailAPI.Data.Models.Dto;

namespace MangoMe.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
    }
}
