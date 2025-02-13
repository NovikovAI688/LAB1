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
        /// <summary>
        /// Имя
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст
        /// </summary>
        private int _age;

        /// <summary>
        /// Пол
        /// </summary>
        private Sex _sex;

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

        //TODO: RSDN +
        /// <summary>
        /// Минимальный возраст
        /// </summary>
        public const int MinAge = 0;

        //TODO: RSDN +
        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public const int MaxAge = 120;

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
                if (value >= MinAge && value <= MaxAge)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException($"Возраст должен находиться " +
                        $"в пределах от {MinAge} года до {MaxAge} лет");
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
            //TODO: RSDN +
            bool nameRu = Regex.IsMatch(name, @"^[а-яА-ЯёЁ\s\-]+$");
            bool surnameRu = Regex.IsMatch(surname, @"^[а-яА-ЯёЁ\s\-]+$");

            bool nameEn = Regex.IsMatch(name, @"^[a-zA-Z\s\-]+$");
            bool surnameEn = Regex.IsMatch(surname, @"^[a-zA-Z\s\-]+$");

            return (nameRu && surnameRu) || (nameEn && surnameEn);
        }

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