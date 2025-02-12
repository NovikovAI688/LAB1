﻿using Model;
using System.Xml.Linq;

namespace LAB1
{
    //TODO: RSDN +
    class Program
    {
        static void Main(string[] args)
        {
            PersonList list1 = new PersonList();
            PersonList list2 = new PersonList();

            list1.Add(new Person("Атрём", "Кирякин", 26, Sex.Male));
            list1.Add(new Person("Виктория", "Тайдонова", 22, Sex.Female));
            list1.Add(new Person("Егор", "Бухаров", 17, Sex.Male));

            list2.Add(new Person("Михаил", "Шлапак", 28, Sex.Male));
            list2.Add(new Person("Александр", "Ушаков", 33, Sex.Male));
            list2.Add(new Person("Павел", "Арефьев", 24, Sex.Male));

            // Выводим содержимое каждого списка
            Console.WriteLine("Список 1:");
            list1.Print();
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();

            Console.WriteLine("\nСписок 2:");
            list2.Print();
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();

            // Добавляем нового человека в первый список
            list1.Add(new Person("Мария", "Николаева", 29, Sex.Female));
            Console.WriteLine("\nПосле добавления нового человека в первый список:");
            list1.Print();
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();

            // Копируем второго человека из первого списка во второй
            Person personCopy = list1.Get(1); //   (второй элемент)
            list2.Add(personCopy);
            Console.WriteLine("\nПосле копирования второго человека из первого списка во второй:");
            Console.WriteLine("\nСписок 1:");
            list1.Print();
            Console.WriteLine("\nСписок 2:");
            list2.Print();
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();

            // Удаляем второго человека из первого списка
            list1.Remove(list1.Get(1));
            Console.WriteLine("\nПосле удаления второго человека из первого списка:");
            Console.WriteLine("\nСписок 1:");
            list1.Print();
            Console.WriteLine("\nСписок 2:");
            list2.Print();
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();

            // Очищаем второй список
            list2.Clear();
            Console.WriteLine("\nПосле очистки второго списка:");
            Console.WriteLine("\nСписок 1:");
            list1.Print();
            Console.WriteLine("\nСписок 2 (очищен):");
            list2.Print();
            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();

            //TODO: RSDN +
            PersonList list3 = new PersonList();

            // Пример использования метода ReadFromConsole
            Console.WriteLine("Введите данные для первого человека:");
            // создаем временного человека
            Person person1 = new Person("", "", 0, Sex.Male); 
            person1 = ReadFromConsole();
            list3.Add(person1);

            // Пример использования метода GetRandomPerson
            Person randomPerson = RandomPerson.GetRandomPerson();
            list3.Add(randomPerson);

            // Вывод списка людей
            Console.WriteLine("\nСписок персон:");
            for (int i = 0; i < list3.Count(); i++)
            {
                list3.Get(i);
                list3.Print();
            }
            // Подождите ввода клавиши для завершения
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        //TODO: extract +
        /// <summary>
        /// Метод для чтения персоны с клавиатуры 
        /// </summary>
        /// <returns> Вовращает персону</returns>
        public static Person ReadFromConsole()
        {
            Person person = new Person("", "", 0, Sex.Male);

            while (true)
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                string surname = Console.ReadLine();
                break;
            }

            // Ввод возраста
            while (true)
            {
                Console.Write("Введите возраст (0 - 120): ");
                string ageInput = Console.ReadLine();
                break;
            }
                // Ввод пола
            while (true)
            {
                Console.Write("Введите пол (Male/Female): ");
                string sexInput = Console.ReadLine();
                break;
            }

            return person;
        }

        /// <summary>
        /// Метод для получения количества элементов
        /// </summary>
        public void Print(Person person)
        {
            Console.WriteLine(person.ToString());
        }
    }

}


