using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Виды для XmlSerializer.
    /// </summary>
    [XmlInclude(typeof(Resistor))]
    [XmlInclude(typeof(Capacitor))]
    [XmlInclude(typeof(InductorCoil))]

    /// <summary>
    /// Класс базового пасивного элемента.
    /// </summary>
    public abstract class PassiveElementBase
    {
        /// <summary>
        /// Минимальное значение.
        /// </summary>
        private const double _minValue = 0.0001;

        /// <summary>
        /// Виды элементов для DataGridView.
        /// </summary>
        public abstract string PassiveElement { get; }

        /// <summary>
        /// Параметры для DataGridView.
        /// </summary>
        public abstract string Parameters { get; }

        /// <summary>
        /// Полное сопротивление для DataGridView.
        /// </summary>
        public abstract string Impedance { get; }

        /// <summary>
        /// Посчитать комплексное полное сопротивление.
        /// </summary>
        [Browsable(false)]
        public abstract Complex GetImpedance { get; }

        /// <summary>
        /// Полное сопртивление для фильтра.
        /// </summary>
        [Browsable(false)]
        public Complex FilterImpedance => FilteredImpedance(GetImpedance, 3);

        /// <summary>
        /// Вывод инфрмации о элементе.
        /// </summary>
        public abstract string Info { get; }

        /// <summary>
        /// Проверка на правильное значение.
        /// </summary>
        /// <param name="value">Входное значение.</param>
        /// <returns>Входное значение.</returns>
        /// <exception cref="ArgumentException">Неправильное значение.</exception>
        protected static double CheckValue(double value)
        {
            if (value <= _minValue)
            {
                throw new ArgumentException
                    ("Значение не может быть отрицательным");
            }
            else
            {
                return value;
            }
        }

            /// <summary>
            /// Округлeние числа полного сопротивления.
            /// </summary>
            /// <param name="complex">Элемент".</param>
            /// <param name="digits">Цифры.</param>
            /// <returns>Полное сопротивление.</returns>
        public static string RoundImpedance
            (Complex complex, int digits)
        {
            double realResistance = Math.Round
                   (complex.Real, digits);
            double imaginaryResistance = Math.Round
                   (complex.Imaginary, digits);

            return ($"{realResistance}" +
                    $" + ({imaginaryResistance})j Ом");
        }

        /// <summary>
        /// Фильтр полного сопроивления.
        /// </summary>
        /// <param name="complex">Отфильтронанное сопртивление..</param>
        /// /// <param name="digits">Цифры.</param>
        /// <returns>Отфильтронанное сопртивление по порядку.</returns>
        public static Complex FilteredImpedance(Complex complex, int digits)
        {
            double realResistance = Math.Round
                (complex.Real, digits);
            double imaginaryResistance = Math.Round
                (complex.Imaginary, digits);
            var newComplex = new Complex(realResistance, imaginaryResistance);
            return newComplex;
        }
    }
    
}
