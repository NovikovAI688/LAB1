namespace Model
{
    //TODO: XML
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

            Sex sex = (Sex)random.Next(0, 2);
            var name = sex == Sex.Male
                ? maleNames[random.Next(maleNames.Length)]
                : femaleNames[random.Next(femaleNames.Length)];
            var surname = sex == Sex.Male
                ? maleNames[random.Next(maleNames.Length)]
                : femaleSurnames[random.Next(femaleSurnames.Length)];
            
            //TODO: get from person
            int age = random.Next(0, 120);
            return new Person(name, surname, age, sex);
        }
    }
}