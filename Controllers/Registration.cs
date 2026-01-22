using Microsoft.AspNetCore.Mvc;
using Личный_кабинет_иностранного_абитуриента.Models;

namespace Личный_кабинет_иностранного_абитуриента.Controllers
{
    public class Registration : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowInfo(User user)
        {
            return View(user);
        }
    }
}
