using MangoMe.Services.ShoppingCartAPI.Models.Dtos;

namespace MangoMe.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
