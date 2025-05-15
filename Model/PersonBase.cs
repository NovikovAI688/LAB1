using System;
using System.Reflection;
using System.Text.RegularExpressions;


namespace Model
{
    /// <summary>
    /// Класс персон
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Имя
        /// </summary>
        private string _name = string.Empty;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname = string.Empty;

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
        public PersonBase(string name, string surname, int age, Sex sex)
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
                _name = CheckForSequence(_surname, value);
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
                _surname = CheckForSequence(_name, value);
            }
        }

        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        protected int _minAge = 0;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        protected int _maxAge = 120;

        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        public virtual int MinAge => _minAge;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        public virtual int MaxAge => _maxAge;

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
                    throw new IndexOutOfRangeException(
                        $"Поле не может быть пустым. " +
                        $"Возраст должен находиться " +
                        $"в пределах от {MinAge} года до {MaxAge} лет");
                }
            }
        }

        /// <summary>
        /// Задание гендера.
        /// </summary>
        public Sex Sex { get; set; }
           
        /// <summary>
        /// Информация о персоне
        /// </summary>
        /// <returns> Вовращает имя и фамилию персоны, скольно ему лет и какого он пола</returns>
        public virtual string GetInfo() 
        {
            return $"Имя: {_name}, Фамилия: {_surname}," +
                    $" Возраст: {_age}, Пол: {_sex}";
        }

        /// <summary>
        /// Имя и фамилия.
        /// </summary>
        /// <returns>Имя и фамилия.</returns>
        public string GetNameSurname() => $"{Name} {Surname}";

        /// <summary>
        /// Проверка на пустую строку и наличие только русских и английских символов.
        /// </summary>
        /// <param name="input">Имя или фамилия для проверки</param>
        /// <returns>Возвращает true, если строка валидная, иначе false</returns>
        public static bool SameLanguage(string firstString, string secondString)
        {
            bool nameRu = Regex.IsMatch(firstString, @"^[а-яА-ЯёЁ\s\-]+$");
            bool surnameRu = Regex.IsMatch(secondString, @"^[а-яА-ЯёЁ\s\-]+$");

            bool nameEn = Regex.IsMatch(firstString, @"^[a-zA-Z\s\-]+$");
            bool surnameEn = Regex.IsMatch(secondString, @"^[a-zA-Z\s\-]+$");

            return (nameRu && surnameRu) || (nameEn && surnameEn);
        }

        /// <summary>
        /// Проверка на имени и фамилии
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static string CheckForSequence(string firstString, string secondString)
        {
            if (!(string.IsNullOrEmpty(secondString) 
                && secondString.Contains(" ")))
            {
                if (firstString == string.Empty)
                {
                    return CapitalizeString(secondString);
                }
                else
                {
                    if (SameLanguage(firstString, secondString))
                    {
                        return CapitalizeString(secondString);
                    }
                }
            }
            throw new ArgumentException(
                    "Ошибка: ячейки фамилия и имя не должны быть пустыми," +
                    " должны содержать только буквы и на одном языке.");
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