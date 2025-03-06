namespace ProfessionalCardWebClientApp.Models
{
    public class CourseDetailsModel
    {
        public Course Course { get; set; }

        public void OnGet(int id)
        {
            // Демонстрационные данные
            var demoCourses = new List<Course>
        {
            new Course { Id = 1, Name = "Основы программирования", Description = "Курс, который познакомит вас с базовыми навыками программирования", Skills = "Программирование, логика", Duration = "3 месяца", Price = 10000, RegistrationLink = "https://example.com/course1" },
            new Course { Id = 2, Name = "Frontend-разработка", Description = "Курс по созданию веб-интерфейсов", Skills = "HTML, CSS, JavaScript", Duration = "4 месяца", Price = 10000, RegistrationLink = "https://example.com/course2" },
            new Course { Id = 3, Name = "Алгоритмы", Description = "Курс, углубляющий знания в алгоритмах", Skills = "Алгоритмы, структуры данных", Duration = "2 месяца", Price = 10000, RegistrationLink = "https://example.com/course3" }
        };

            Course = demoCourses.FirstOrDefault(c => c.Id == id) ?? new Course();
        }
    }
}
