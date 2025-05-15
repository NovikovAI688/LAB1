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
        /// Серия пасспорта
        /// </summary>
        private int _passportSeria;

        /// <summary>
        /// Номер пасспорта
        /// </summary>
        private int _passportNumber;

        /// <summary>
        /// Муж или жена
        /// </summary>
        private Adult _partner;

        //BUG: +
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
        /// Minimum age.
        /// </summary>
        protected override int MinAge { get; } = _minAge;

        /// <summary>
        /// Maximum age.
        /// </summary>
        protected override int MaxAge { get; } = _maxAge;

        /// <summary>
        /// мин серия
        /// </summary>
        private const int _minPassportSeria = 1000;

        /// <summary>
        /// макс серия
        /// </summary>
        private const int _maxPassportSeria = 9999;

        /// <summary>
        /// мин номер
        /// </summary>
        private const int _minPassportNumber = 100000;

        /// <summary>
        /// макс номер
        /// </summary>
        private const int _maxPassportNumber = 999999;

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
                        $"в пределах от {Adult._minAge} года" +
                        $"до {Adult._maxAge} лет");
                }
            }
        }

        /// <summary>
        /// Пасспортные данные(серия)
        /// </summary>
        public int PassportSeria
        {
            get => _passportSeria;
            set
            {
                if (value >= _minPassportSeria && value <= _maxPassportSeria)
                {
                    _passportSeria = value;
                }
                else
                {
                    throw new IndexOutOfRangeException(
                        $"Серия пасспорта находится " +
                        $"в пределах от {_minPassportSeria} " +
                        $"до {_passportSeria}");
                }
            }
        }

        /// <summary>
        /// Пасспортные данные(номер)
        /// </summary>
        public int PassportNumber
        {
            get => _passportNumber;
            set
            {
                if (value >= _minPassportNumber && value <= _maxPassportNumber)
                {
                    _passportNumber = value;
                }
                else
                {
                    throw new IndexOutOfRangeException(
                        $"Номер пасспорта находится " +
                        $"в пределах от {_minPassportNumber} " +
                        $"до {_passportNumber}");
                }
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
        /// Check gender of adult's partner.
        /// </summary>
        /// <param name="partner">Partner.</param>
        /// <exception cref="ArgumentException">Incorrect input.</exception>
        private void CheckPartnerGender(Adult partner)
        {
            if (partner != null && partner.Sex == Sex)
            {
                throw new ArgumentException
                    ("Не могут быть одного пола");
            }
        }

        /// <summary>
        /// Ввод мужа или жены
        /// </summary>
        public Adult Partner
        {
            get
            {
                return _partner;
            }
            set
            {
                CheckPartnerGender(value);
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
        /// <param name="passportSeria">Серия пасспорта.</param>
        /// <param name="passportNumber">Номер пасспорта.</param>
        /// <param name="partner">Муж/жена.</param>
        /// <param name="workPlace">Место работы.</param>
        public Adult(string name, string surname, int age,
            Sex sex, int passportSeria, int passportNumber, Adult partner,
            string workPlace) : base(name, surname, age, sex)
        {
            PassportSeria = passportSeria;
            PassportNumber = passportNumber;
            WorkPlace = workPlace;
            Partner = partner;
        }


        /// <summary>
        /// вывод информации о человеке
        /// </summary>
        public override string GetInfo()
        {
            string partnerInfo = Partner != null 
                ? $"Замужем/женат на: {Partner.Name}" 
                : "Не состоит в браке";
            string workplaceInfo = !string.IsNullOrEmpty(WorkPlace)
                ? WorkPlace 
                : "Безработный";
            return $"{base.Name}, Возраст: {base.Age}," +
                   $"Серия пасспорта: {PassportSeria}," +
                   $"Номер пасспорта: {PassportNumber}, " +
                   $"{partnerInfo}, Место работы: {workplaceInfo}";
        }

    }
}
    