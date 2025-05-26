using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace StudentSerializationApp
{
    // 1. Класс Студент
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        // Конструктор
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{Name} - Grade: {Grade}";
        }
    }

    public static class StudentSerializer
    {
        // 2. Сохранение списка студентов в JSON файл
        public static void SaveToFile(List<Student> students, string filePath)
        {
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // 3. Загрузка списка студентов из JSON файла
        public static List<Student> LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                return new List<Student>();
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Student>>(json);
        }
    }

 /*   class Program
    {
        static void Main()
        {
            string path = "students.json";

            // 4. Создание списка студентов
            List<Student> students = new List<Student>
            {
                new Student("Алексей", 5),
                new Student("Мария", 4),
                new Student("Иван", 3)
            };

            // Сохраняем список в файл
            StudentSerializer.SaveToFile(students, path);
            Console.WriteLine("Список студентов сохранен.");

            // Загружаем список обратно
            var loadedStudents = StudentSerializer.LoadFromFile(path);
            Console.WriteLine("\nЗагруженные студенты из файла:");

            foreach (var student in loadedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }*/
}
