using Microsoft.AspNetCore.Mvc;
using ProfessionalCardWebClientApp.Models;

namespace ProfessionalCardWebClientApp.Controllers
{
    public class CareerPathController : Controller
    {
        // Пример данных
        private static readonly List<RouteSuggestion> Routes = new List<RouteSuggestion>
        {
            new RouteSuggestion
            {
                Level = "Начальный уровень",
                Path = new List<string> { "Основы программирования", "Git для начинающих", "Frontend-разработчик" }
            },
            new RouteSuggestion
            {
                Level = "Средний уровень",
                Path = new List<string> { "Алгоритмы и структуры данных", "Проектирование архитектуры", "Middle-разработчик" }
            },
            new RouteSuggestion
            {
                Level = "Эксперт",
                Path = new List<string> { "Микросервисы", "Оптимизация производительности", "Senior-разработчик" }
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateRoute(string education, string skills, string interests)
        {
            // Простая логика для демонстрации
            var suggestedRoutes = Routes;

            // В реальной системе логика может учитывать образование, навыки и интересы
            if (!string.IsNullOrWhiteSpace(skills) && skills.ToLower().Contains("программирование"))
            {
                suggestedRoutes = Routes.Where(r => r.Level != "Начальный уровень").ToList();
            }

            return Json(new { success = true, routes = suggestedRoutes });
        }

        // Модель маршрута
        public class RouteSuggestion
        {
            public string Level { get; set; }
            public List<string> Path { get; set; }
        }
    }
}
