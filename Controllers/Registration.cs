using Microsoft.AspNetCore.Mvc;

namespace Личный_кабинет_иностранного_абитуриента.Controllers
{
    public class Registration : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
