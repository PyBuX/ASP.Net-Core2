using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BSUIR_VIS.Domain.Data;
using BSUIR_VIS.Domain.Entities;
using BSUIR_VIS.Domain.Models;

namespace BSUIR_VIS.API.Controllers
{
    // BSUIR_VIS.API/Controllers/CategoriesController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseData<List<Category>>>> GetCategories()
        {
            try
            {
                var categories = await _context.Categories.ToListAsync();
                return ResponseData<List<Category>>.Success(categories);
            }
            catch (Exception ex)
            {
                return ResponseData<List<Category>>.Error(ex.Message);
            }
        }
    }
}
