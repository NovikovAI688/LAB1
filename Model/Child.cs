using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Child : PersonBase
    {
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
        /// Минимальный возраст ребенка
        /// </summary>
        private const int MinAge = 0;

        /// <summary>
        /// Максимальный возраст ребенка
        /// </summary>
        private const int MaxAge = 16;

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
        /// Create an instance of class Child.
        /// </summary>
        /// <param name="name">Name of the person.</param>
        /// <param name="surname">Surname of the person.</param>
        /// <param name="age">Age of the person.</param>
        /// <param name="sex">Gender of the person.</param>
        /// <param name="father">Child's father.</param>
        /// <param name="mother">Child's mother.</param>
        /// <param name="school">Child's school.</param>
        public Child(string name, string surname, int age,
            Sex sex, Adult father, Adult mother,
            string school) : base(name, surname, age, sex)
        {
            Father = father;
            Mother = mother;
            School = school;
        }

        /// <summary>
        /// Create an instance of class Child without parameters.
        /// </summary>
        public Child() : this("Unknown", "Unknown", 11,
            Sex.Male, null, null, null)
        {
            
        }

        /// <summary>
        /// Информация о ребенке
        /// </summary>
        /// <returns>Информация о ребенке.</returns>
        public override string GetPersonInfo()
        {
            var fatherStatus = "Нет отца";
            var motherStatus = "Нет мамы";

            if (Father != null)
            {
                fatherStatus = $"Отец: {Father.GetPersonInfo()}";
            }

            if (Mother != null)
            {
                motherStatus = $"Мама: {Mother.GetPersonInfo()}";
            }

            var schoolStatus = "Не обучается в школе";
            if (!string.IsNullOrEmpty(School))
            {
                schoolStatus = $"Учиться в {School}-ой школе";
            }

            return $"{GetPersonInfo()};\n {fatherStatus}; {motherStatus};" +
                $" {schoolStatus}\n";
        }

        /// <summary>
        /// Check parent's gender's.
        /// </summary>
        /// <param name="parent">A certain adult parent.</param>
        /// <param name="gender">Gender of the parent.</param>
        /// <exception cref="ArgumentException">Parent's gender's must
        /// differ from each other.</exception>
        private static void CheckParentGender
            (Adult parent, Sex sex)
        {
            if (parent != null && parent.Sex == sex)
            {
                throw new ArgumentException
                    ("Пол родителя должен быть другим");
            }
        }

        /// <summary>
        /// Пол на рандом
        /// </summary>
        /// <param name="sex">Рандомный пол.</param>
        public static Adult GetRandomParent(Sex sex)
        {
            var random = new Random();
            var parentStatus = random.Next(0, 2);
            if (parentStatus == 1)
            {
                return null;
            }
            else
            {
                return Adult.GetRandomPerson(sex);
            }
        }

        /// <summary>
        /// Рандом (ребенок)
        /// </summary>
        /// <returns>Инфа о ребенке</returns>
        public static Child GetRandomPerson()
        {
            string[] maleNames =
            {
                 "Liam", "Noah", "Oliver", "Elijah", "James",
                 "William", "Benjamin", "Colin", "Lucas", "Marcus"
             };

            string[] femaleNames =
            {
                 "Dolores", "Leta", "Pansy", "Olivia", "Tracey",
                 "Charlotte", "Katie", "Mia", "Sophia", "Alicia"
             };

            string[] surnames =
            {
                 "Smith", "Jones", "Weasley", "Williams", "Taylor",
                 "Brown", "Davies", "Carrow", "Evans", "Thomas"
             };

            string[] schools =
            {
                "28", "32", "4", "56"
            };

            var random = new Random();
            var tmpNumber = random.Next(1, 3);

            Sex tmpSex = tmpNumber == 1
                ? Sex.Male
                : Sex.Female;

            string tmpName = tmpSex == Sex.Male
                ? maleNames[random.Next(maleNames.Length)]
                : femaleNames[random.Next(femaleNames.Length)];

            var tmpSurname = surnames[random.Next(surnames.Length)];

            var tmpAge = random.Next(MinAge + 1, MaxAge);

            Adult tmpFather = GetRandomParent(Sex.Male);

            Adult tmpMother = GetRandomParent(Sex.Female);

            var schoolStatus = random.Next(0, 2);
            string tmpSchool = schoolStatus == 1
                ? schools[random.Next(schools.Length)]
                : null;

            return new Child(tmpName, tmpSurname, tmpAge, tmpSex,
                tmpFather, tmpMother, tmpSchool);
        }

    }
}

