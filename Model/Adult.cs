namespace Model
{
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

        /// <summary>
        /// Место работы
        /// </summary>
        private string _workPlace;

        /// <summary>
        /// Минимальный возраст
        /// </summary>
        public int MinAge => _minAge;

        /// <summary>
        /// Максимальный возраст
        /// </summary>
        public int MaxAge => base.MaxAge;

        /// <summary>
        /// мин серия
        /// </summary>
        public  const int _minPassportSeria = 1000;

        /// <summary>
        /// макс серия
        /// </summary>
        public const int _maxPassportSeria = 9999;

        /// <summary>
        /// мин номер
        /// </summary>
        public const int _minPassportNumber = 100000;

        /// <summary>
        /// макс номер
        /// </summary>
        public const int _maxPassportNumber = 999999;

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
                if (value >= MinAge && value <= MaxAge)
                {
                    _ageAdult = value;
                }
                else
                {
                    throw new IndexOutOfRangeException(
                        $"Возраст слишком маленький. " +
                        $"Возраст взрослого должен находиться " +
                        $"в пределах от {MinAge} года" +
                        $"до {MaxAge} лет");
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
        /// Дефолт образ
        /// </summary>
        public Adult() : this("", "",0,Sex.Male,1563,569847,"") 
        {

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
            Sex sex, int passportSeria, int passportNumber,
            string workPlace) : base(name, surname, age, sex)
        {
            PassportSeria = passportSeria;
            PassportNumber = passportNumber;
            WorkPlace = workPlace;
            _minAge = 18;
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
            return $"{GetPersonInfo()}" +
                   $"Серия пасспорта: {PassportSeria}," +
                   $"Номер пасспорта: {PassportNumber}, " +
                   $"{partnerInfo}, Место работы: {workplaceInfo}";
        }
    }
}
    