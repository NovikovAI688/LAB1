using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс базового пасивного элемента.
    /// </summary>
    public abstract class PassiveElementBase
    {
        /// <summary>
        /// Минимальное значение.
        /// </summary>
        private const int _minValue = 0;

        /// <summary>
        /// Расчет комплексного сопротивления.
        /// </summary>
        public abstract Complex Impedance { get; }

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
    }
}
