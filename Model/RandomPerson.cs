using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace Model
{
    /// <summary>
    /// Класс случайной персоны
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// Рандом(взрослый)
        /// </summary>
        /// <returns>Информация о взрослом</returns>
        /// <param name="sex">Пол </param>
        public static Adult GetRandomAdult(Sex sex = Sex.Default)
        {
            Adult adult = new Adult();
            Child child = new Child();
            string[] maleNames =
            {
                 "John", "Carl", "Rick", "Mattew",
                "Nicholas", "Robert", "Samuel",
                "Stan", "Kenny", "Severus", "Jake"
             };

            string[] femaleNames =
            {
                 "Lyla", "Samanta", "Kate", "Kira",
                "Amelia", "Julia", "Anastasia",
                "Sindy", "Luna", "Violet", "Anna"
             };

            string[] surnames =
            {
                 "Potter", "Granger", "Black", "Malfoy",
                "Weasley", "Dursley", "Riddle", "Krum",
                "Snape", "Lovegood", "Lestrange"
             };

            string[] workPlaceList =
            {
                 "Rosseti", "RusHydro",
                 "Rosatom", "NTC",
                 "1xBet", "Megafon",
                 "Tinkoff", "Gazprom"
            };

            var random = new Random();
            string name = string.Empty;

            if (sex == Sex.Default)
            {
                var tmpNumber = random.Next(0, 2);
                sex = tmpNumber == 0
                    ? Sex.Male
                    : Sex.Female;
            }

            switch (sex)
            {
                case Sex.Male:
                    name = maleNames[random.Next(maleNames.Length)];
                    break;
                case Sex.Female:
                    name = femaleNames[random.Next(femaleNames.Length)];
                    break;
                case Sex.Default:
                    break;
                default:
                    break;
            }

            string surname = surnames[random.Next(surnames.Length)];
            int age = random.Next(child.MinAge, adult.MaxAge);

            int passportSeria = random.Next(Adult._minPassportSeria,
                                            Adult._maxPassportSeria);
            int passportNumber = random.Next(Adult._minPassportNumber,
                                             Adult._maxPassportNumber);
            string workPlace = workPlaceList[random.Next(workPlaceList.Length)];

            Adult partner = null;
            int marriegeStatus = random.Next(0, 2);
            if (marriegeStatus == 0)
            {
                partner = new Adult();
                if (sex == Sex.Male)
                {
                    partner.Sex = Sex.Male;
                    partner.Name = maleNames
                        [random.Next(maleNames.Length)];

                }
                else
                {
                    partner.Sex = Sex.Female;
                    partner.Name = femaleNames
                        [random.Next(femaleNames.Length)];
                }

                partner.Surname = surnames
                    [random.Next(surnames.Length)];
            }

            return new Adult(name, surname, age, sex,
                            passportSeria, passportNumber, workPlace);
        }

        /// <summary>
        /// Пол на рандом родителей
        /// </summary>
        /// <param name="sex">Рандомный пол.</param>
        private static Adult GetRandomParent(int numberParent)
        {
            var random = new Random();
            var parentStatus = random.Next(0, 2);

            if (parentStatus == 0)
            {
                return null;
            }
            else
            {
                switch (numberParent)
                {
                    case 0:
                        return GetRandomAdult(Sex.Male);
                    case 1:
                        return GetRandomAdult(Sex.Female);
                    default:
                        throw new ArgumentException
                            ("Номера [0; 1].");
                }
            }
        }

        /// <summary>
        /// Рандом (ребенок)
        /// </summary>
        /// <returns>Инфа о ребенке</returns>
        public static Child GetRandomChild()
        {
            Child child = new Child();
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
            string name = string.Empty;
            var sex = (Sex)random.Next(0, 2);
            switch (sex)
            {
                case Sex.Male:
                    name = maleNames[random.Next(maleNames.Length)];
                    break;
                case Sex.Female:
                    name = femaleNames[random.Next(femaleNames.Length)];
                    break;
                case Sex.Default:
                    break;
                default:
                    break; ;
            }

            string surname = surnames[random.Next(surnames.Length)];
            int age = random.Next(child.MinAge, child.MaxAge);

            string school = schools[random.Next(schools.Length)];

            Adult mother = GetRandomParent(1);
            Adult father = GetRandomParent(0);

            return new Child(name, surname, age, sex,
                            father,mother, school);
        }
    }
}