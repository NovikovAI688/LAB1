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
        public static Adult GetRandomPerson(Sex sex = Sex.Male)
        {
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

            bool[] familyStatusList =
            {
                 true,false
            };

            Random random = new Random();

            sex = (Sex)random.Next(0, 2);
            var name = sex == Sex.Male
                ? maleNames[random.Next(maleNames.Length)]
                : femaleNames[random.Next(femaleNames.Length)];
            var surname = sex == Sex.Male
                ? maleNames[random.Next(maleNames.Length)]
                : surnames[random.Next(surnames.Length)];

            int age = random.Next(PersonBase.MinAge, PersonBase.MaxAge);

            string tmpWorkPlace = workPlaceList
                                  [random.Next(workPlaceList.Length)];

            Adult tmpPartner = null;
            bool tmpfamilyStatus = familyStatusList
                                   [random.Next(familyStatusList.Length)];

            int passportSeria = random.Next(0001, 9999);
            int passportNumber = random.Next(000001, 999999);

            if (tmpfamilyStatus)
            {
                tmpPartner = new Adult(name, surname, 19, sex,
                passportSeria, passportNumber, tmpfamilyStatus, tmpWorkPlace);

                tmpPartner.Name = sex == Sex.Female
                    ? maleNames[random.Next(maleNames.Length)]
                    : femaleNames[random.Next(femaleNames.Length)];

                tmpPartner.Surname = surnames[random.Next(surnames.Length)];
            }
            else
            {
                tmpPartner = null;
            }
                return new Adult(name, surname, age, sex, passportSeria,
                                 passportNumber, tmpfamilyStatus,tmpWorkPlace);
        }

        //TODO: remove +
        /// <summary>
        /// Пол на рандом родителей
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
                return  GetRandomPerson(sex);
            }
        }
        //TODO: remove +
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
            var tmpNumber = random.Next(0, 2);

            Sex tmpSex = tmpNumber == 1
                ? Sex.Male
                : Sex.Female;

            string tmpName = tmpSex == Sex.Male
                ? maleNames[random.Next(maleNames.Length)]
                : femaleNames[random.Next(femaleNames.Length)];

            var tmpSurname = surnames[random.Next(surnames.Length)];

            var tmpAge = random.Next(0,17);

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