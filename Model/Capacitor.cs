using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс конденсатора.
    /// </summary>
    public class Capacitor : PassiveElementBase
    {
        /// <summary>
        /// Емкость.
        /// </summary>
        private double _сapacity;

        /// <summary>
        /// Чаастота.
        /// </summary>
        private double _frequency;

        /// <summary>
        /// Значение емкости.
        /// </summary>
        public double Capacity
        {
            get => _сapacity;
            set => _сapacity = CheckValue(value);
        }

        /// <summary>
        /// Значение частоты.
        /// </summary>
        public double Frequency
        {
            get => _frequency;
            set => _frequency = CheckValue(value);
        }

        /// <summary>
        /// Состав конденсатора.
        /// </summary>
        /// <param name="сapacity">Capacity.</param>
        /// <param name="frequency">Frequency.</param>
        public Capacitor(double сapacity, double frequency)
        {
            Capacity = сapacity;
            Frequency = frequency;
        }

        /// <summary>
        /// Пустой состав конденсатора.
        /// </summary>
        public Capacitor() { }

        /// <summary>
        /// Расчет комплексного сопротивления.
        /// </summary>
        public override Complex Impedance =>
            new Complex(0, (1 / (2 * Math.PI * Frequency * Capacity)));

        /// <summary>
        /// Выводит информацию о элементе.
        /// </summary>
        public override string Info =>
            //TODO: rewrite +
            $"\nХарактеристики кондерсатора:\n" +
            $"Емкость = {Capacity} Ф\n" +
            $"Частота = {Frequency} Гц";
    }
}
