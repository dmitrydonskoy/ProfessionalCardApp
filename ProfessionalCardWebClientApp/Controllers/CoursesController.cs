using Microsoft.AspNetCore.Mvc;
using ProfessionalCardWebClientApp.Models;

namespace ProfessionalCardWebClientApp.Controllers
{
    public class CoursesController : Controller
    {
        private static readonly List<Course> Courses = new List<Course>
        {
            new Course { Id = 1, Name = "Основы программирования", Description = "Изучение базовых концепций программирования.", Direction = "IT", Format = "Онлайн", Skills = "Логика, алгоритмы", Duration = "6 недель", Price = 5000, RegistrationLink = "https://example.com/register1" },
            new Course { Id = 2, Name = "Графический дизайн", Description = "Основы работы с графикой и дизайном.", Direction = "Дизайн", Format = "Оффлайн", Skills = "Креативность, Photoshop", Duration = "4 недели", Price = 7000, RegistrationLink = "https://example.com/register2" },
            new Course { Id = 3, Name = "Инженерные расчеты", Description = "Инженерные методы и расчеты.", Direction = "Инженерия", Format = "Онлайн", Skills = "Аналитика, расчеты", Duration = "8 недель", Price = 10000, RegistrationLink = "https://example.com/register3" }
        };

        public IActionResult Index(string direction, string format, string skills)
        {
            var filteredCourses = Courses.AsQueryable();

            if (!string.IsNullOrEmpty(direction))
                filteredCourses = filteredCourses.Where(c => c.Direction == direction);

            if (!string.IsNullOrEmpty(format))
                filteredCourses = filteredCourses.Where(c => c.Format == format);

            if (!string.IsNullOrEmpty(skills))
                filteredCourses = filteredCourses.Where(c => c.Skills.Contains(skills));

            return View(filteredCourses.ToList());
        }

        public IActionResult Details(int id)
        {
            var course = Courses.FirstOrDefault(c => c.Id == id);
            if (course == null)
                return NotFound();

            return View(course);
        }
    }

}
