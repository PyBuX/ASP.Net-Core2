using Microsoft.AspNetCore.Mvc;
using BSUIR_VIS.API.Services;
using BSUIR_VIS.Domain.Entities;
using BSUIR_VIS.Domain.Models;

namespace BSUIR_VIS.UI.Controllers
{
    // BSUIR_VIS.UI/Controllers/CatalogController.cs
    public class CatalogController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public CatalogController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index(string? category, int pageNo = 1)
        {
            try
            {
                var categoriesResponse = await _categoryService.GetCategoryListAsync();
                if (!categoriesResponse.Successfull)
                {
                    // Обработка ошибки
                    ViewBag.Categories = new List<Category>();
                    ViewBag.Error = categoriesResponse.ErrorMessage;
                }
                else
                {
                    ViewBag.Categories = categoriesResponse.Data;
                }

                var productsResponse = await _productService.GetProductListAsync(category, pageNo);
                if (!productsResponse.Successfull)
                {
                    // Обработка ошибки
                    ViewBag.Error = productsResponse.ErrorMessage;
                    return View(new ListModel<Dish>());
                }

                ViewBag.CurrentCategory = category;
                return View(productsResponse.Data);
            }
            catch (Exception ex)
            {
                // Обработка ошибки
                ViewBag.Categories = new List<Category>();
                ViewBag.Error = "Произошла ошибка при загрузке данных";
                return View(new ListModel<Dish>());
            }
        }
    }
}
