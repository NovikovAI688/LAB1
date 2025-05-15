using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Ребенок
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Возраст ребенка
        /// </summary>
        private int _ageChild;

        /// <summary>
        /// Отец
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Мама
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Школа.
        /// </summary>
        private string _school;


        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        public int MinAge => base.MinAge;

        /// <summary>
        /// Максимальный возраст.
        /// </summary>
        public int MaxAge => _maxAge;
        /// <summary>
        /// Отец ребенка
        /// </summary>
        public Adult Father
        {
            get => _father;
            set
            {
                CheckParentGender(value, Sex.Female);
                _father = value;
            }
        }

        /// <summary>
        /// Мама ребенка
        /// </summary>
        public Adult Mother
        {
            get => _mother;
            set
            {
                CheckParentGender(value, Sex.Male);
                _mother = value;
            }
        }

        /// <summary>
        /// Школа
        /// </summary>
        public string School
        {
            get => _school;
            set
            {
                _school = value;
            }
        }

        /// <summary>
        /// Задание возраста ребенка.
        /// </summary>
        public int AgeChild
        {
            get
            {
                return _ageChild;
            }

            set
            {
                if (value >= MinAge && value <= MaxAge)
                {
                    _ageChild = value;
                }
                else
                {
                    throw new IndexOutOfRangeException(
                        $"Возраст слишком большой. " +
                        $"Возраст ребенка должен находиться " +
                        $"в пределах от {MinAge} года до " +
                        $"{MaxAge} лет");
                }
            }
        }

        /// <summary>
        /// Образ ребенка.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="AgeChild">Возраст.</param>
        /// <param name="sex">Пол.</param>
        /// <param name="father">Папа.</param>
        /// <param name="mother">Мама.</param>
        /// <param name="school">Шокла.</param>
        public Child(string name, string surname, int AgeChild,
            Sex sex, Adult father, Adult mother,
            string school) : base(name, surname, AgeChild, sex)
        {
            Father = father;
            Mother = mother;
            School = school;
            _maxAge = 17;
        }

        /// <summary>
        /// Default child
        /// </summary>
        public Child() : this("Mikey", "Mouse", 11,
            Sex.Male, null,null,"" )
        {
            
        }

        /// <summary>
        /// Информация о ребенке
        /// </summary>
        /// <returns>Информация о ребенке.</returns>
        public override string GetInfo()
        {
            var fatherStatus = "Нет отца";
            var motherStatus = "Нет мамы";

            if (Father != null)
            {
                fatherStatus = $"Отец: {Father.GetInfo()}";
            }

            if (Mother != null)
            {
                motherStatus = $"Мама: {Mother.GetInfo()}";
            }

            var schoolStatus = "Не обучается в школе";
            if (!string.IsNullOrEmpty(School))
            {
                schoolStatus = $"Учиться в {School}-ой школе";
            }

            if (Mother == null && Father == null)
            {
                return Sex == Sex.Female
                    ? $"{GetInfo()} \n{schoolStatus}" +
                        $"\nОна сирота"
                    : $"{GetInfo()} \n{schoolStatus}" +
                        $"\nОн сирота";
            }
            else
            {

                return $"{GetInfo()};\n {fatherStatus}; {motherStatus};" +
                $" {schoolStatus}\n";
            }
        }

        /// <summary>
        /// Проверка пола.
        /// </summary>
        /// <param name="parent">Взрослый</param>
        /// <param name="gender">Пол взрослого</param>
        /// <exception cref="ArgumentException">Взрослый должен
        /// быть другого пола</exception>
        private static void CheckParentGender
            (Adult parent, Sex sex)
        {
            if (parent != null && parent.Sex == sex)
            {
                throw new ArgumentException
                    ("Пол родителя должен быть другим");
            }
        }
    }
}

