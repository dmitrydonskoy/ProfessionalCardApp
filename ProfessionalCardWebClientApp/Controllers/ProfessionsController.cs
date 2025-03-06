using Microsoft.AspNetCore.Mvc;
using ProfessionalCardWebClientApp.Models;

namespace ProfessionalCardWebClientApp.Controllers
{
    public class ProfessionsController : Controller
    {
        public IActionResult Index()
        {
            // Пример данных для страницы
            var professions = new List<Profession>
            {
                new Profession { Id = 1, Name = "Разработчик", Description = "Создает и поддерживает программное обеспечение." },
                new Profession { Id = 2, Name = "Дизайнер", Description = "Разрабатывает дизайн интерфейсов и макетов." },
                new Profession { Id = 3, Name = "Аналитик данных", Description = "Анализирует данные и создает отчеты." }
            };

            return View(professions);
        }
    }
}
