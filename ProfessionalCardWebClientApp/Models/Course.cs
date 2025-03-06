namespace ProfessionalCardWebClientApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Direction { get; set; } // Направление (IT, Дизайн и т.д.)
        public string Format { get; set; } // Формат (онлайн/оффлайн)
        public string Skills { get; set; } // Компетенции
        public string Duration { get; set; } // Длительность
        public decimal Price { get; set; } // Стоимость
        public string RegistrationLink { get; set; } // Ссылка на регистрацию
    }
}
