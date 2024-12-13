using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB1
{
    public enum Sex
    {
        Male,
        Female
    }
    public class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public Sex Sex { get; private set; }

        public Person(string _name, string _surname, int _age, Sex _sex)
        {
            Name = _name;
            Surname = _surname;
            Age = _age;
            Sex = _sex;
        }
        public override string ToString() 
        {
            return ($"Имя: {Name}, Фамилия: {Surname}," +
                    $" Возраст: {Age}, Пол: {Sex}");
        }

        // Метод для чтения персоны с клавиатуры
        public void ReadFromConsole()
        {
            // Ввод имени
            while (true)
            {
                Console.Write("Введите имя: ");
                string nameInput = Console.ReadLine();
                if (IsValidName(nameInput))
                {
                    Name = CapitalizeName(nameInput);
                    break;
                }
                Console.WriteLine("Ошибка: имя должно содержать только буквы и не может быть пустым.");
            }

            // Ввод фамилии
            while (true)
            {
                Console.Write("Введите фамилию: ");
                string surnameInput = Console.ReadLine();
                if (IsValidSurname(surnameInput))
                {
                    Surname = CapitalizeName(surnameInput);
                    break;
                }
                Console.WriteLine("Ошибка: фамилия должна содержать только буквы и не может быть пустой.");
            }

            // Ввод возраста
            while (true)
            {
                Console.Write("Введите возраст (0 - 120): ");
                string ageInput = Console.ReadLine();
                if (int.TryParse(ageInput, out int age) && age >= 0 && age <= 120)
                {
                    Age = age;
                    break;
                }
                Console.WriteLine("Ошибка: возраст должен быть числом от 0 до 120.");
            }

            // Ввод пола
            while (true)
            {
                Console.Write("Введите пол (Male/Female): ");
                string sexInput = Console.ReadLine();
                if (Enum.TryParse(typeof(Sex), sexInput, true, out var sex))
                {
                    Sex = (Sex)sex;
                    break;
                }
                Console.WriteLine("Ошибка: введите корректный пол (Male/Female).");
            }
        }

        private bool IsValidName(string name)
        {
            // Проверка на пустую строку и наличие только русских и английских символов
            return !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[a-zA-Zа-яА-ЯёЁ\s\-]+$");
        }
         
        private bool IsValidSurname(string surname)
        {
            // Проверка на пустую строку и наличие только русских и английских символов
            return !string.IsNullOrWhiteSpace(surname) && Regex.IsMatch(surname, @"^[a-zA-Zа-яА-ЯёЁ\s\-]+$");
        }

        private string CapitalizeName(string name)
        {
            // Приведение строки к правильному регистру для имени и фамилии
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
        }

        // Метод для вывода персоны на экран
        public void Print()
        {
            Console.WriteLine($"Имя: {Name}, Фамилия: {Surname}, Возраст: {Age}, Пол: {Sex}");
        }

        // Статический метод для генерации случайной персоны
        public static Person GetRandomPerson()
        {
            Random random = new Random();
            string[] names = { "Иван", "Анна", "Дмитрий", "Елена", "Сергей", "Ольга", "Мария" };
            string[] surnames = { "Иванов", "Петрова", "Сидоров", "Кузнецов", "Федоров", "Николаев" };

            string randomName = names[random.Next(names.Length)];
            string randomSurname = surnames[random.Next(surnames.Length)];
            int randomAge = random.Next(18, 61); // Возраст от 18 до 60
            Sex randomSex = (Sex)random.Next(0, 2); // Случайный пол (0 или 1)

            return new Person(randomName, randomSurname, randomAge, randomSex);
        }

        
    }
    
}
