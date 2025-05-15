using Model;
using System;

namespace LAB1
{
    /// <summary>
    /// Операции с персонами
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Создание списков 
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Создаем список.");

            var personList = new PersonList();
            var random = new Random();

            for (var i = 0; i < 7; i++)
            {
                PersonBase randomPerson = random.Next(0, 2) == 0
                    ? RandomPerson.GetRandomAdult()
                    : RandomPerson.GetRandomChild();
                personList.Add(randomPerson);
            }

            Console.WriteLine("\nСписок:");
            PrintList(personList);
        }

        /// <summary>
        /// Отобразить список.
        /// </summary>
        /// <param name="personList">Список.</param>
        /// <exception cref="NullReferenceException">
        /// Неправильн.</exception>
        public static void PrintList(PersonList personList)
        {
            if (personList.Count()==0)
            {
                throw new NullReferenceException("Список пуст");
            }
            else
            {
                for (int i = 0; i < personList.Count(); i++)
                {
                    var tmpPerson = personList.Get(i);
                    Console.WriteLine($"\n{tmpPerson.GetInfo()}");
                }
            }
        }
    }
}

