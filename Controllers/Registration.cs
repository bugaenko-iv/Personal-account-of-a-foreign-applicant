using Microsoft.AspNetCore.Mvc;
using Личный_кабинет_иностранного_абитуриента.Models;
using Личный_кабинет_иностранного_абитуриента.Data; // ДОБАВЛЕНО: чтобы видеть контекст базы

namespace Личный_кабинет_иностранного_абитуриента.Controllers
{
    public class Registration : Controller
    {
        private readonly ApplicationDbContext _context; // Поле для хранения связи с БД

        // Конструктор: когда контроллер создается, ASP.NET сама передает в него базу
        public Registration(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowInfo(User user)
        {
            if (ModelState.IsValid) // Проверка, что данные введены корректно
            {
                _context.Users.Add(user); // Кладем данные в "корзину" (таблицу Users)
                _context.SaveChanges();   // Физически сохраняем изменения в SQL Server
            }

            return View(user); // Показываем страницу с введенными данными
        }
    }
}
