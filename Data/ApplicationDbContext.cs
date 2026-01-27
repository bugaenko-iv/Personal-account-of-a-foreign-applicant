using Microsoft.EntityFrameworkCore; // Это "двигатель" для работы с БД
using Личный_кабинет_иностранного_абитуриента.Models; // Чтобы он видел вашу модель User

namespace Личный_кабинет_иностранного_абитуриента.Data
{
    // Наследуемся от DbContext — это делает класс "главным по базе"
    public class ApplicationDbContext : DbContext
    {
        // Этот конструктор нужен, чтобы передать настройки (адрес сервера) из Program.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Каждое свойство DbSet — это будущая ТАБЛИЦА в базе данных
        // Мы говорим: "Создай таблицу Users на основе модели User"
        public DbSet<User> Users { get; set; }
    }
}
