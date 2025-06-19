using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс резисторы.
    /// </summary>
    public class Resistor : PassiveElementBase
    {
        /// <summary>
        /// Сопротивление резистора.
        /// </summary>
        private double _resistance;

        /// <summary>
        /// Вид элемента для DataGridView.
        /// </summary>
        public override string PassiveElement => "Resistor";

        /// <summary>
        /// Параметры для DataGridView.
        /// </summary>
        public override string Parameters => $"R = {Resistance} Ом";

        /// <summary>
        /// Полное сопртивление для DataGridView.
        /// </summary>
        public override string Impedance => RoundImpedance(GetImpedance, 3);

        /// <summary>
        /// Значение сопротивления.
        /// </summary>
        public double Resistance
        {
            get => _resistance;
            set => _resistance = CheckValue(value);
        }

        /// <summary>
        /// Resistor's constructor.
        /// </summary>
        /// <param name="resistance">resistance.</param>
        public Resistor(double resistance)
        {
            Resistance = resistance;
        }

        /// <summary>
        /// Пустой элемент
        /// </summary>
        public Resistor()
        {
        }

        /// <summary>
        /// Расчет комплексного сопротивления.
        /// </summary>
        public override Complex GetImpedance =>
            new Complex(Resistance, 0);

        /// <summary>
        /// Выводит информацию о элементе.
        /// </summary>
        public override string Info =>
            $"\nХарактеристики резистора:\n" +
            $"Сопротивление = {Resistance} Ом";
    }
}
