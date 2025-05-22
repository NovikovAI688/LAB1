using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Выбор элемента (пасивный).
    /// </summary>
    public enum PassiveElementType
    {
        /// <summary>
        /// Резистор.
        /// </summary>
        Resistor,

        /// <summary>
        /// Индуктивность.
        /// </summary>
        InductorCoil,

        /// <summary>
        /// Конденсатор.
        /// </summary>
        Capacitor
    }
}
