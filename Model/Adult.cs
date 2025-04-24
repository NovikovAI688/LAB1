using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //TODO: XML +
    /// <summary>
    /// Взрослый
    /// </summary>
    public class Adult: PersonBase
    {

        /// <summary>
        /// Возраст взрослого
        /// </summary>
        private int _ageAdult;

        /// <summary>
        /// Номер пасспорта
        /// </summary>
        private string _passportData;

        /// <summary>
        /// В браке или холост
        /// </summary>
        //private bool _familyStatus;

        /// <summary>
        /// Муж или жена
        /// </summary>
        private Adult _partner;

        //BUG:
        /// <summary>
        /// Муж или жена
        /// </summary>
        private string _workPlace;

        /// <summary>
        /// Минимальный возраст для взрослого
        /// </summary>
        private const int _minAge = 18;

        /// <summary>
        /// Максимальный возраст для взрослого
        /// </summary>
        private const int _maxAge = 120;

        /// <summary>
        /// Задание возраста взрослого.
        /// </summary>
        public int AgeAdult
        {
            get
            {
                return _ageAdult;
            }

            set
            {
                if (value >= Adult._minAge && value <= Adult._maxAge)
                {
                    _ageAdult = value;
                }
                else
                {
                    throw new IndexOutOfRangeException(
                        $"Возраст слишком маленький. " +
                        $"Возраст взрослого должен находиться " +
                        $"в пределах от {Adult._minAge} года до {Adult._maxAge} лет");
                }
            }
        }

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
        /// Ввод мужа или жены
        /// </summary>
        public bool FamilyStatus
        {
            get; set;
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
            Sex sex, string passportData,
            string workPlace) : base(name, surname, age, sex)
        {
            PassportData = passportData;
            WorkPlace = workPlace;
        }

        public Adult() : this("Biba", "Boba", 25, Sex.Male, "1111111111", "NTC")
        { 
            
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
    }
}
    