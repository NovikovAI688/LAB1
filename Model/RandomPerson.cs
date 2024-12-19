namespace Model
{
    public class RandomPerson
    {
        /// <summary>
        /// Генерирует случайного человека
        /// </summary>
        /// <returns>Персона со случайными данными</returns>
        public static Person GetRandomPerson()
        {
            string[] maleNames = new string[]
            {
                "John", "Carl", "Rick", "Mattew",
                "Nicholas", "Robert", "Samuel",
                "Stan", "Kenny", "Severus", "Jake"
            };

            string[] femaleNames = new string[]
            {
                "Lyla", "Samanta", "Kate", "Kira",
                "Amelia", "Julia", "Anastasia",
                "Sindy", "Luna", "Violet", "Anna"
            };

            string[] maleSurnames = new string[]
            {
                "Potter", "Granger", "Black", "Malfoy",
                "Weasley", "Dursley", "Riddle",
                "Krum", "Snape", "Lovegood", "Lestrange"
            };
            string[] femaleSurnames = new string[]
            {
                "Potter", "Granger", "Black", "Malfoy",
                "Weasley", "Dursley", "Riddle",
                "Krum", "Snape", "Lovegood", "Lestrange"
            };

            Random random = new Random();

            string name;
            Sex sex = (Sex)random.Next(0, 2);
            switch (sex)
            {
                case Sex.Male:
                    name = maleNames[random.Next(maleNames.Length)];
                    break;
                case Sex.Female:
                    name = femaleNames[random.Next(femaleNames.Length)];
                    break;
                default:
                    return new Person("", "", 0, Sex.Male);
            }

            string surname;
            switch (sex)
            {
                case Sex.Male:
                    surname = maleSurnames[random.Next(maleSurnames.Length)];
                    break;
                case Sex.Female:
                    surname = femaleSurnames[random.Next(femaleSurnames.Length)];
                    break;
                default:
                    return new Person("", "", 0, Sex.Male);
            }

            int age = random.Next(0, 120);
            return new Person(name, surname, age, sex);
        }

    }
}
