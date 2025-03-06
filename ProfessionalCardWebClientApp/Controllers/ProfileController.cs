using Microsoft.AspNetCore.Mvc;
using ProfessionalCardWebClientApp.Models;

namespace ProfessionalCardWebClientApp.Controllers
{
    public class ProfileController : Controller
    {
        
            // Пример данных пользователя
            private static readonly UserProfile User = new UserProfile
            {
                Name = "Иван Иванов",
                Education = "Бакалавр информатики",
                WorkExperience = "2 года в IT",
                Interests = "Программирование, дизайн",
                SavedProfessions = new List<string> { "Программист", "Дизайнер" },
                SavedCourses = new List<string> { "Основы программирования", "UI/UX дизайн" },
                CurrentRoute = "Начинающий программист → Middle-разработчик",
                CompletedSteps = new List<string> { "Основы программирования", "Git для начинающих" },
                Recommendations = new List<string> { "Курс: Алгоритмы и структуры данных", "Профессия: Data Scientist" }
            };

            public IActionResult Index()
            {
                return View(User);
            }

            [HttpPost]
            public IActionResult UpdateProfile(UserProfile updatedProfile)
            {
                // Обновляем данные пользователя
                User.Name = updatedProfile.Name;
                User.Education = updatedProfile.Education;
                User.WorkExperience = updatedProfile.WorkExperience;
                User.Interests = updatedProfile.Interests;

                return RedirectToAction("Index");
            }
        }
    }

