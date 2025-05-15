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
        public static void Main()
        {
            Console.WriteLine("The crew has been created.");

            var personList = new PersonList();
            var random = new Random();

            for (var i = 0; i < 7; i++)
            {
                PersonBase randomPerson = random.Next(0, 2) == 0
                    ? GetRandomAdult(Sex.Male)
                    : Child.GetRandomChild(Sex.Male);
                personList.Add(randomPerson);
            }

            _ = Console.ReadKey();

            Console.WriteLine("\nBelow are the crew members:");
            PrintList(personList);
        }

        /// <summary>
        /// Отобразить список.
        /// </summary>
        /// <param name="personList">PersonList.</param>
        /// <exception cref="NullReferenceException">
        /// Incorrect input.</exception>
        public static void PrintList(PersonList personList)
        {
            if (personList.Length == 0)
            {
                throw new NullReferenceException("List is empty.");
            }
            else
            {
                for (int i = 0; i < personList.Length; i++)
                {
                    var tmpPerson = personList.Get(i);
                    Console.WriteLine($"\n{tmpPerson.GetInfo()}");
                }
            }

        ///// <summary>
        ///// Метод распаковки actionList
        ///// </summary>
        ///// <param name="propertyHandelerDto">actionList</param>
        //public static void PersonHandler(PropertyHandlerDTO propertyHandelerDto)
        //{
        //    var personField = propertyHandelerDto.PropertyName;
        //    var personTypes = propertyHandelerDto.ExceptionTypes;
        //    var personAction = propertyHandelerDto.PropertyHandlingAction;
        //    Console.WriteLine($"Введите {personField} персоны:");
        //    while (true)
        //    {
        //        try
        //        {
        //            personAction.Invoke();
        //            break;
        //        }
        //        catch (Exception e)
        //        {
        //            if (personTypes.Contains(e.GetType()))
        //            {
        //                Console.WriteLine(e.Message);
        //                Console.WriteLine($"Введите {personField} заново");
        //                continue;
        //            }
        //            throw e;
        //        }
        //    }
        //}

        ///// <summary>
        ///// Метод для чтения персоны с клавиатуры 
        ///// </summary>
        ///// <returns> Вовращает персону</returns>
        //public static PersonBase ReadFromConsole()
        //{
        //    PersonBase person = new("Biba", "Boba", 0, Sex.Male);
        //    var actionList = new List<PropertyHandlerDTO>
        //{
        //    new PropertyHandlerDTO("имя",
        //        new List<Type>
        //        {
        //           typeof(ArgumentException),
        //        },
        //        () =>
        //        {
        //            person.Name = Console.ReadLine();
        //        }),
        //    new PropertyHandlerDTO("фамилию",
        //        new List<Type>
        //        {
        //           typeof(ArgumentException),
        //        },
        //        () =>
        //        {
        //           person.Surname = Console.ReadLine();
        //        }),
        //    new PropertyHandlerDTO("возраст от 0 до 120",
        //        new List<Type>
        //        {
        //           typeof(IndexOutOfRangeException),
        //           typeof(FormatException),
        //        },
        //        () =>
        //        {
        //           person.Age = Convert.ToInt32(Console.ReadLine());
        //        }),
        //    new PropertyHandlerDTO("пол Male/Female (1/0)",
        //        new List<Type>
        //        {
        //            typeof(ArgumentNullException),
        //            typeof(ArgumentException),
        //        },
        //        () =>
        //        {
        //            string[] sexMaleList = ["Male", "M", "1", "М", "м"];
        //            string[] sexFemaleList = ["Female", "F", "0"];
        //            string sexPerson = Console.ReadLine();
        //            if (sexMaleList.Contains(sexPerson.ToLower()))
        //            {
        //                person.Sex = Sex.Male;
        //            }
        //            else if (sexFemaleList.Contains(sexPerson.ToLower()))
        //            {
        //                person.Sex  = Sex.Female;
        //            }
        //            else
        //            {
        //                var maleMessage = string.Join(", ",
        //                    sexMaleList.Select(x => $"'{x}'"));
        //                var femaleMessage = string.Join(", ",
        //                    sexFemaleList.Select(x => $"'{x}'"));
        //                throw new ArgumentException(
        //                    "Для мужчин значения пола " +
        //                    $"могут иметь значения {maleMessage}\n" +
        //                    "Для женщин значения пола " +
        //                    $"могут иметь значения {femaleMessage}");
        //            }
        //        })

        //};

        //    for (int i = 0; i < actionList.Count; i++)
        //    {
        //        PersonHandler(actionList[i]);
        //    }

        //    Console.WriteLine(person.ToString());
        //    return person;
        //}
        

    }

}

