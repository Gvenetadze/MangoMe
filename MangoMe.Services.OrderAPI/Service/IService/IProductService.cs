using MangoMe.Services.OrderAPI.Models.Dto;

namespace MangoMe.Services.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
