using Model;
using System.Xml.Linq;

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
        public static void Main(string[] args)
        {
            PersonList list1 = new PersonList();
            PersonList list2 = new PersonList();

            list1.Add(new Person("Атрем", "Кирякин", 26, Sex.Male));
            list1.Add(new Person("Виктория", "Тайдонова", 22, Sex.Female));
            list1.Add(new Person("Егор", "Бухаров", 17, Sex.Male));

            list2.Add(new Person("Михаил", "Шлапак", 28, Sex.Male));
            list2.Add(new Person("Александр", "Ушаков", 33, Sex.Male));
            list2.Add(new Person("Павел", "Арефьев", 24, Sex.Male));

            // Выводим содержимое каждого списка
            Console.WriteLine("Список 1:");
            list1.Print();
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey(true);

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

            PersonList list3 = new PersonList();

            // Пример использования метода ReadFromConsole
            Console.WriteLine("Введите данные для первого человека:");
            // создаем временного человека
        
            Person person1 = ReadFromConsole();
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

        /// <summary>
        /// Метод распаковки actionList
        /// </summary>
        /// <param name="propertyHandelerDto">actionList</param>
        public static void PersonPropertiesHandler(PropertyHandlerDTO propertyHandelerDto)
        {
            var personField = propertyHandelerDto.PropertyName;
            var personTypes = propertyHandelerDto.ExceptionTypes;
            var personAction = propertyHandelerDto.PropertyHandlingAction;
            Console.WriteLine($"Введите {personField} персоны:");
            while (true)
            {
                try
                {
                    personAction.Invoke();
                    break;
                }
                catch (Exception e)
                {
                    if (personTypes.Contains(e.GetType()))
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine($"Введите {personField} заново");
                        continue;
                    }
                    throw e;
                }
            }
        }

        /// <summary>
        /// Метод для чтения персоны с клавиатуры 
        /// </summary>
        /// <returns> Вовращает персону</returns>
        public static Person ReadFromConsole()
        {
            Person person = new Person(" ", " ", 0, Sex.Male);
            //TODO: duplication +
            var actionList = new List<PropertyHandlerDTO>
            {
                new PropertyHandlerDTO("имя",
                    new List<Type>
                        {
                           typeof(ArgumentException),
                        },
                    () => { person.Name = Console.ReadLine(); }),
                 new PropertyHandlerDTO("фамилию",
                    new List<Type>
                        {
                           typeof(ArgumentException),
                        },
                    () => { person.Surname = Console.ReadLine(); }),
                  new PropertyHandlerDTO("возраст",
                    new List<Type>
                        {
                           typeof(IndexOutOfRangeException),
                           typeof(FormatException),
                        },
                    () => { person.Age = Convert.ToInt32(Console.ReadLine()); }),
                   new PropertyHandlerDTO("пол",
                    new List<Type>
                        {
                           typeof(ArgumentNullException),
                           typeof(ArgumentException),
                        },
                    () => { string[] sex_male_list = ["Male", "M", "1"];
                            string[] sex_female_list = ["Female", "F", "0"];
                            string SexPerson = Console.ReadLine();
                            if (sex_male_list.Contains(SexPerson.ToLower()))
                            {
                                person.Sex = Sex.Male;
                            }
                            else if (sex_female_list.Contains(SexPerson.ToLower()))
                            {
                                person.Sex  = Sex.Female;
                            }
                            else
                            {
                                throw new ArgumentException("Для мужчин значения пола могут иметь значения 'Male', 'M', '1'\n" +
                                                            "Для женщин значения пола могут иметь значения 'Female', 'F', '0'");
                            }
                            })

        };

            for (int i = 0; i < actionList.Count; i++)
            {
                PersonPropertiesHandler(actionList[i]);
            }

            Console.WriteLine(person.ToString());
            return person;
        }



    }

}


