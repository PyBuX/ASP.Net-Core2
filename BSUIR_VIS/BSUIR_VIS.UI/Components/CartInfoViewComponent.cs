using Microsoft.AspNetCore.Mvc;
using BSUIR_VIS.UI.Models;

namespace BSUIR_VIS.UI.Components
{
    public class CartInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new CartInfoViewModel { TotalPrice = 0, ItemCount = 0 });
        }
    }
}
