using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс катушки индуктивности.
    /// </summary>
    public class InductorCoil : PassiveElementBase
    {
        /// <summary>
        /// Индунтивность.
        /// </summary>
        private double _inductance;

        /// <summary>
        /// Частота.
        /// </summary>
        private double _frequency;

        /// <summary>
        /// Значение индуктивности.
        /// </summary>
        public double Inductance
        {
            get => _inductance;
            set => _inductance = CheckValue(value);
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
        /// Состав катушки индуктивности.
        /// </summary>
        /// <param name="inductance">Inductance.</param>
        /// <param name="frequency">Frequency.</param>
        public InductorCoil(double inductance, double frequency)
        {
            Inductance = inductance;
            Frequency = frequency;
        }

        /// <summary>
        /// Пустой соств катушки индуктивности.
        /// </summary>
        public InductorCoil()
        {
        }

        /// <summary>
        /// Расчет комплексного сопротивления.
        /// </summary>
        public override Complex Impedance =>
            new Complex(0, 2 * Math.PI * Frequency
                * Inductance);

        /// <summary>
        /// Выводит информацию о элементе.
        /// </summary>
        public override string Info =>
            $"\nСharacteristics of the inductor coil:\n" +
            $"Inductance = {Inductance} H\n" +
            $"Frequency = {Frequency} Hz";
    }
}
