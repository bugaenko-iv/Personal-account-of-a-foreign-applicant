using Microsoft.EntityFrameworkCore; // ДОБАВЛЕНО
using Личный_кабинет_иностранного_абитуриента.Data; // ДОБАВЛЕНО
using Личный_кабинет_иностранного_абитуриента.Models;

namespace Личный_кабинет_иностранного_абитуриента
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // ДОБАВЛЕНО: Связываем проект с SQL Server
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(); // Раньше было MapStaticAssets, стандартно для доступа к css/js

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Registration}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
