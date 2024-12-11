using Microsoft.AspNetCore.Mvc;

namespace BSUIR_VIS.UI.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult LogOut()
        {
            // Логика выхода
            return RedirectToAction("Index", "Home");
        }
    }
}
