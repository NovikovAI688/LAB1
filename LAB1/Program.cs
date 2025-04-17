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
            Console.WriteLine("Создать список и добавить 7 людей:");
            Console.WriteLine();
            var listOfPeople = new PersonList();
            var rnd = new Random();

            for (int i = 0; i <= 7; i++)
            {
                PersonBase rndPerson = rnd.Next(2) == 0
                    ? (PersonBase)Adult.GetRandomPerson()
                    : (PersonBase)Child.GetRandomPerson();
                listOfPeople.Add(rndPerson);
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
                PersonBase person = new(" ", " ", 0, Sex.Male);
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

}

