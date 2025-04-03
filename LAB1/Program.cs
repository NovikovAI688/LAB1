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
            Adult parent1 = new Adult("Артем", "Кирякин", 26, Sex.Male, "7224 054367", "Married", null, "Company A");
            Adult parent2 = new Adult("Виктория", "Тайдонова", 23, Sex.Female, "7682 631587", "Married", parent1, "Company B");

            List<Adult> parents = new List<Adult> { parent1, parent2 };
            Child child = new Child("Егор", "Бухаров", 3, Sex.Male, parents, "СОШ 21");

            Console.WriteLine(parent1.GetPersonInfo());
            Console.WriteLine(parent2.GetPersonInfo());
            Console.WriteLine(child.GetPersonInfo());

            PersonList list1 = new PersonList();
            PersonList list2 = new PersonList();

            list1.Add(new PersonBase("Артем", "Кирякин", 26, Sex.Male));
            list1.Add(new PersonBase("Виктория", "Тайдонова", 22, Sex.Female));
            list1.Add(new PersonBase("Егор", "Бухаров", 17, Sex.Male));

            list2.Add(new PersonBase("Михаил", "Шлапак", 28, Sex.Male));
            list2.Add(new PersonBase("Александр", "Ушаков", 33, Sex.Male));
            list2.Add(new PersonBase("Павел", "Арефьев", 24, Sex.Male));

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
            list1.Add(new PersonBase("Мария", "Николаева", 29, Sex.Female));
            Console.WriteLine("\nПосле добавления нового человека в первый список:");
            list1.Print();
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();

            // Копируем второго человека из первого списка во второй
            PersonBase personCopy = list1.Get(1); //   (второй элемент)
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

            PersonBase person1 = ReadFromConsole();
            list3.Add(person1);

            // Пример использования метода GetRandomPerson
            PersonBase randomPerson = RandomPerson.GetRandomPerson();
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
        public static void PersonHandler(PropertyHandlerDTO propertyHandelerDto)
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
        public static PersonBase ReadFromConsole()
        {
            PersonBase person = new PersonBase(" ", " ", 0, Sex.Male);
            var actionList = new List<PropertyHandlerDTO>
            {
                new PropertyHandlerDTO("имя",
                    new List<Type>
                    {
                       typeof(ArgumentException),
                    },
                    () => 
                    { 
                        person.Name = Console.ReadLine(); 
                    }),
                new PropertyHandlerDTO("фамилию",
                    new List<Type>
                    {
                       typeof(ArgumentException),
                    },
                    () => 
                    { 
                       person.Surname = Console.ReadLine(); 
                    }),
                new PropertyHandlerDTO("возраст от 0 до 120",
                    new List<Type>
                    {
                       typeof(IndexOutOfRangeException),
                       typeof(FormatException),
                    },
                    () =>
                    { 
                       person.Age = Convert.ToInt32(Console.ReadLine()); 
                    }),
                new PropertyHandlerDTO("пол Male/Female (1/0)",
                    new List<Type>
                    {
                        typeof(ArgumentNullException),
                        typeof(ArgumentException),
                    },
                    () => 
                    { 
                        string[] sexMaleList = ["Male", "M", "1", "М", "м"];                            
                        string[] sexFemaleList = ["Female", "F", "0"];
                        string sexPerson = Console.ReadLine();
                        if (sexMaleList.Contains(sexPerson.ToLower()))
                        {
                            person.Sex = Sex.Male;
                        }
                        else if (sexFemaleList.Contains(sexPerson.ToLower()))
                        {
                            person.Sex  = Sex.Female;
                        }
                        else
                        {
                            var maleMessage = string.Join(", ", 
                                sexMaleList.Select(x => $"'{x}'"));
                            var femaleMessage = string.Join(", ", 
                                sexFemaleList.Select(x => $"'{x}'"));
                            throw new ArgumentException(
                                "Для мужчин значения пола " +
                                $"могут иметь значения {maleMessage}\n" +
                                "Для женщин значения пола " +
                                $"могут иметь значения {femaleMessage}");
                        }
                    })

            };

            for (int i = 0; i < actionList.Count; i++)
            {
                PersonHandler(actionList[i]);
            }

            Console.WriteLine(person.ToString());
            return person;
        }
    }

}


