using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Adult: PersonBase
    {
        /// <summary>
        /// Номер пасспорта
        /// </summary>
        private string _passportData;

        /// <summary>
        /// В браке или холост
        /// </summary>
        private string _familyStatus;

        /// <summary>
        /// Муж или жена
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Муж или жена
        /// </summary>
        private Adult _workPlace;

        /// <summary>
        /// Минимальный возраст для взрослого
        /// </summary>
        private const int MinAge = 18;

        /// <summary>
        /// Максимальный возраст для взрослого
        /// </summary>
        protected const int MaxAge = 120;

        /// <summary>
        /// Пасспортные данные
        /// </summary>
        public string PassportData
        {
            get => _passportData;
            set
            {
                
                _passportData = value;
            }
        }

        /// <summary>
        /// Ввод места работы
        /// </summary>
        public string WorkPlace
        {
            get => _workPlace;
            set
            {
                _workPlace = value;
            }
        }

        /// <summary>
        /// Ввод мужа или жены
        /// </summary>
        public Adult Partner
        {
            get => _partner;
            set
            {
                _partner = value;
            }
        }

        /// <summary>
        /// Пример
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="surname">Фамилия человека.</param>
        /// <param name="age">Возраст человека.</param>
        /// <param name="sex">Пол человека.</param>
        /// <param name="passportData">Номер пасспорта.</param>
        /// <param name="partner">Муж/жена.</param>
        /// <param name="workPlace">Место работы.</param>
        public Adult(string name, string surname, int age,
            Sex sex, string passportData, Adult partner,
            string workPlace) : base(name, surname, age, sex)
        {
            PassportData = passportData;
            WorkPlace = workPlace;
            Partner = partner;
        }

        /// <summary>
        /// вывод информации о человеке
        /// </summary>
        public override string GetPersonInfo()
        {
            string partnerInfo = Partner != null 
                ? $"Замужем/женат на: {Partner.Name}" 
                : "Не состоит в браке";
            string workplaceInfo = !string.IsNullOrEmpty(WorkPlace)
                ? WorkPlace 
                : "Безработный";
            return $"{base.Name}, Возраст: {base.Age}, Номер пасспорта: {PassportData}, " +
                   $"{partnerInfo}, Место работы: {workplaceInfo}";
        }

        /// <summary>
        /// Method which allows to enter a random adult.
        /// </summary>
        /// <returns>Information about an adult.</returns>
        /// <param name="gender">Start gender.</param>
        public static Adult GetRandomPerson
            (Sex sex = Sex.Male)
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

            string[] employers =
            {
                 "Rosseti", "RusHydro",
                 "Rosatom", "NTC",
                 "1xBet", "Megafon",
                 "Tinkoff", "Gazprom"
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

            Adult tmpPartner = null;
            var familyStatus = random.Next(0, 2);
            if (familyStatus == 1)
            {
                tmpPartner = new Adult();

                tmpPartner.Name = sex == Sex.Female
                    ? maleNames[random.Next(maleNames.Length)]
                    : femaleNames[random.Next(femaleNames.Length)];

                tmpPartner.Surname = surnames[random.Next(surnames.Length)];
            }

            var workPlace = random.Next(0, 2);
            string tmpWorkPlace = workPlace == 1
                ? workPlace[random.Next(workPlace.Lenght)]
                : null;

            return new Adult(name, surname, age, sex,
                tmpPartner, tmpWorkPlace);
        }


    }
}
    