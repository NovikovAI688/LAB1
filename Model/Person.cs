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
        public string Name { get;  set; }

        //TODO: XML +
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get;  set; }

        //TODO: XML +
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }    

        //TODO: XML +
        /// <summary>
        /// Пол
        /// </summary>
        public Sex Sex { get; set; }

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
        /// Информация о персоне
        /// </summary>
        /// <returns> Вовращает имя и фамилию персоны, скольно ему лет и какого он пола</returns>
        public override string ToString() 
        {
            return ($"Имя: {Name}, Фамилия: {Surname}," +
                    $" Возраст: {Age}, Пол: {Sex}");
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
                && Regex.IsMatch(name, @"^[a-zA-Zа-яА-ЯёЁ\s\-]+$")
                && Regex.IsMatch(surname, @"^[a-zA-Zа-яА-ЯёЁ\s\-]+$")
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

        //TODO: duplication
        /// <summary>
        /// Информация о персоне
        /// </summary>
        /// <returns> Вовращает имя  персоны, в правильном регистре</returns>
        public static string CapitalizeString(string capitilizingString)
        {
            // Приведение строки к правильному регистру для имени и фамилии
            return System.Globalization.CultureInfo.
                CurrentCulture.TextInfo.ToTitleCase(capitilizingString.ToLower());
        }

        /// <summary>
        /// Минимальный возраст
        /// </summary>
        public const int minAge = 0;
        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public const int maxAge = 120;
    }    
}