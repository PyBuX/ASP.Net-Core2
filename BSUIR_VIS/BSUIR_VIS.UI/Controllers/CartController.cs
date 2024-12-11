using Microsoft.AspNetCore.Mvc;

namespace BSUIR_VIS.UI.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
