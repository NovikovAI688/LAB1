using Model;
using System.Xml.Linq;

namespace LAB3
{
    /// <summary>
    /// Класс программы.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Главное.
        /// </summary>
        public static void Main()
        {
            /// <summary>
            /// Список элементов.
            /// </summary>
            var elemetList = new List<PassiveElementBase>();
            while (true)
            {
                switch (SelectElement())
                {
                    case 1:
                        {
                            elemetList.Add(ShowImpedance(
                                EnterValues(PassiveElementType.Resistor)));
                            break;
                        }

                    case 2:
                        {
                            elemetList.Add(ShowImpedance(
                                EnterValues(PassiveElementType.InductorCoil)));
                            break;
                        }

                    case 3:
                        {
                            elemetList.Add(ShowImpedance(
                                EnterValues(PassiveElementType.Capacitor)));
                            break;
                        }
                    case 4:
                        {
                            return;
                        }

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Отображение сопротивления с помощью консоли.
        /// </summary>
        /// <param name="passiveElementBase">Элемент.</param>
        /// <returns>Базовый элемент.</returns>
        public static PassiveElementBase ShowImpedance
            (PassiveElementBase passiveElementBase)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            RoundImpedance(passiveElementBase, 4);
            Console.ForegroundColor = ConsoleColor.White;
            return passiveElementBase;
        }

        /// <summary>
        /// Округленеие результата.
        /// </summary>
        /// <param name="passiveElementBase">Элемент.</param>
        /// <param name="digits">Цифры.</param>
        public static void RoundImpedance
            (PassiveElementBase passiveElementBase, int digits)
        {
            double realResistance = Math.Round
                (passiveElementBase.Impedance.Real, digits);
            double imaginaryResistance = Math.Round
                (passiveElementBase.Impedance.Imaginary, digits);

            Console.WriteLine($"Сопротивление = {realResistance}" +
                $" + ({imaginaryResistance})j Ом");
        }

        /// <summary>
        /// Цикл для выбора.
        /// </summary>
        /// <returns>Номер выбранного элемента.</returns>
        /// <exception cref="ArgumentException">Неправильное значение.</exception>
        /// <exception cref="IndexOutOfRangeException">
        /// Неправильное значение.</exception>
        public static int SelectElement()
        {
            int chosenPassiveElement = 0;

            var actionList = new List<(Action Action, string)>
            {
                (
                    () =>
                    {
                    if (!int.TryParse(Console.ReadLine(), out int tmpChoice))
                    {
                        throw new ArgumentException
                           ("Введите число.");
                    }

                    if (tmpChoice < 1 || tmpChoice > 4)
                    {
                        throw new IndexOutOfRangeException
                            ("Число в диапазоне [1; 4].");
                    }

                    chosenPassiveElement = tmpChoice;
                    },

                    "\nПожалуйста, введите число:\n" +
                    "1 - резистор, 2 - катушка индуктивности, 3 - конденсатор," +
                    "4 - выход:"
                )
            };

            foreach (var action in actionList)
            {
                ActionHandler(action.Action, action.Item2);
            }

            return chosenPassiveElement;
        }

        /// <summary>
        /// Введите значения элемента.
        /// </summary>
        /// <param name="passiveElementType">Тип элемента.</param>
        /// <returns>Элемент.</returns>
        public static PassiveElementBase EnterValues
            (PassiveElementType passiveElementType)
        {
            PassiveElementBase elementObject = new Resistor();
            switch (passiveElementType)
            {
                case PassiveElementType.Resistor:
                    {
                        elementObject = new Resistor();
                        break;
                    }

                case PassiveElementType.InductorCoil:
                    {
                        elementObject = new InductorCoil();
                        break;
                    }

                case PassiveElementType.Capacitor:
                    {
                        elementObject = new Capacitor();
                        break;
                    }

                default:
                    {
                        break;
                    }
            }

            var actionResistor = new List<(Action Action, string)>
            {
                (
                    () =>
                    {
                        var resistor = (Resistor)elementObject;
                        resistor.Resistance =
                            Convert.ToDouble(Console.ReadLine());
                    },
                    "\nВведите сопротивление резистора:"
                )
            };

            var actionInductorCoil = new List<(Action Action, string)>
            {
                (
                    () =>
                    {
                        var inductorCoil = (InductorCoil)elementObject;
                        inductorCoil.Inductance =
                            Convert.ToDouble(Console.ReadLine());
                    },
                    "\nВведите индуктивность катушки индуктивности:"
                ),
                (
                    () =>
                    {
                        var inductorCoil = (InductorCoil)elementObject;
                        inductorCoil.Frequency =
                            Convert.ToDouble(Console.ReadLine());
                    },
                    "\nВведите частоты катушки индуктивности:"
                )
            };

            var actionCapacitor = new List<(Action Action, string)>
            {
                (
                    () =>
                    {
                        var capacitor = (Capacitor)elementObject;
                        capacitor.Capacity =
                            Convert.ToDouble(Console.ReadLine());
                    },
                    "\nВведите емкость конденсатора:"
                ),
                (
                    () =>
                    {
                        var capacitor = (Capacitor)elementObject;
                        capacitor.Frequency =
                            Convert.ToDouble(Console.ReadLine());
                    },
                    "\nВведите частота конденсатора:"
                )
            };

            var actionDictionary =
                new Dictionary<Type, List<(Action Action, string)>>
            {
                {typeof(Resistor), actionResistor },
                {typeof(InductorCoil), actionInductorCoil },
                {typeof(Capacitor), actionCapacitor },
            };

            var tmpActionsCollection = actionDictionary
                [elementObject.GetType()];
            foreach (var action in tmpActionsCollection)
            {
                ActionHandler(action.Action, action.Item2);
            }

            return elementObject;
        }

        /// <summary>
        /// Исправление.
        /// </summary>
        /// <param name="action">Действие.</param>
        /// <param name="inputMessage">Входящее сообщение.</param>
        private static void ActionHandler
            (Action action, string inputMessage)
        {
            while (true)
            {
                Console.WriteLine(inputMessage);
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Повторите ввод");
                }
            }
        }

    }
}


