using BSUIR_VIS.Domain.Entities;
using BSUIR_VIS.Domain.Models;

namespace BSUIR_VIS.API.Services
{

    // BSUIR_VIS.UI/Services/ICategoryService.cs
    public interface ICategoryService
    {
        Task<ResponseData<List<Category>>> GetCategoryListAsync();
    }
}
