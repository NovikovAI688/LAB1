using System;
using System.Reflection;
using System.Text.RegularExpressions;


namespace Model
{
    /// <summary>
    /// Класс персон
    /// </summary>
    public class Person
    {
        //TODO: XML +
        /// <summary>
        /// Имя
        /// </summary>
        private string _name { get;  set; }

        //TODO: XML +
        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname { get;  set; }

        //TODO: XML +
        /// <summary>
        /// Возраст
        /// </summary>
        private int _age { get; set; }

        //TODO: XML +
        /// <summary>
        /// Пол
        /// </summary>
        private Sex _sex { get; set; }

        /// <summary>
        /// Cоздает персону
        /// </summary>
        /// <param name="Name">Имя персоны</param>
        /// <param name="Surname">Фамилия персоны</param>
        /// <param name="age">Количество лет персоны</param>
        /// <param name="sex">Пол персоны</param>
        public Person(string name, string surname, int age, Sex sex)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
        }

        /// <summary>
        /// Задание имени
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (IsValidInput(value, "Мама"))
                {
                    _name = CapitalizeString(value);
                }
                else
                {
                    throw new ArgumentException(
                        "Ошибка: ячейки фамилия и имя не должны быть пустыми," +
                        " должны содержать только буквы и на одном языке.");
                }
            }
        }

        /// <summary>
        /// Задание фамилии
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (IsValidInput(Name, value))
                {
                    _surname = CapitalizeString(value);
                }
                else
                {
                    throw new ArgumentException(
                        "Ошибка: ячейки фамилия и имя не должны быть пустыми," +
                        " должны содержать только буквы и на одном языке.");
                }
            }
        }

        /// <summary>
        /// Минимальный возраст
        /// </summary>
        public const int minAge = 0;
        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public const int maxAge = 120;

        /// <summary>
        /// Задание возраста.
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value >= minAge && value <= maxAge)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException($"Возраст должен находиться " +
                        $"в пределах от {minAge} года до {maxAge} лет");
                }
            }
        }

        /// <summary>
        /// Задание гендера.
        /// </summary>
        public Sex Sex
        {
            get
            {
                return _sex;
            }

            set
            {
                _sex = value;
            }
        }

        /// <summary>
        /// Информация о персоне
        /// </summary>
        /// <returns> Вовращает имя и фамилию персоны, скольно ему лет и какого он пола</returns>
        public override string ToString() 
        {
            return ($"Имя: {_name}, Фамилия: {_surname}," +
                    $" Возраст: {_age}, Пол: {_sex}");
        }

        /// <summary>
        /// Проверка на пустую строку и наличие только русских и английских символов.
        /// </summary>
        /// <param name="input">Имя или фамилия для проверки</param>
        /// <returns>Возвращает true, если строка валидная, иначе false</returns>
        public static bool IsValidInput(string name, string surname)
        {
            return !string.IsNullOrWhiteSpace(name)
                && !string.IsNullOrWhiteSpace(surname)
                && SameLanguage(name, surname);
        }

        /// <summary>
        /// Проверка на пустую строку и наличие только русских и английских символов.
        /// </summary>
        /// <param name="input">Имя или фамилия для проверки</param>
        /// <returns>Возвращает true, если строка валидная, иначе false</returns>
        public static bool SameLanguage(string name, string surname)
        {
            //TODO: RSDN
            bool name_ru = Regex.IsMatch(name, @"^[а-яА-ЯёЁ\s\-]+$");
            bool surname_ru = Regex.IsMatch(surname, @"^[а-яА-ЯёЁ\s\-]+$");

            bool name_en = Regex.IsMatch(name, @"^[a-zA-Z\s\-]+$");
            bool surname_en = Regex.IsMatch(surname, @"^[a-zA-Z\s\-]+$");

            return (name_ru && surname_ru) || (name_en && surname_en);
        }

        //TODO: duplication +
        /// <summary>
        /// Информация о персоне
        /// </summary>
        /// <returns> Вовращает имя  персоны, в правильном регистре</returns>
        public static string CapitalizeString(string capitilizingString)
        {
            return System.Globalization.CultureInfo.
                CurrentCulture.TextInfo.ToTitleCase(capitilizingString.ToLower());
        }
    }    
}