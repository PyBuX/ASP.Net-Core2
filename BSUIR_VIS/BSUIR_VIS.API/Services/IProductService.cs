using BSUIR_VIS.Domain.Entities;
using BSUIR_VIS.Domain.Models;

namespace BSUIR_VIS.API.Services
{
    // BSUIR_VIS.UI/Services/IProductService.cs
    public interface IProductService
    {
        Task<ResponseData<ListModel<Dish>>> GetProductListAsync(string? categoryNormalizedName, int pageNo = 1);
        Task<ResponseData<Dish>> GetProductByIdAsync(int id);
        Task UpdateProductAsync(int id, Dish product, IFormFile? formFile);
        Task DeleteProductAsync(int id);
        Task<ResponseData<Dish>> CreateProductAsync(Dish product, IFormFile? formFile);
    }
}
