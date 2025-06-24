using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    //TODO: XML +
    /// <summary>
    /// Класс SingleView.
    /// </summary>
    public static class SingleView
    {
        /// <summary>
        /// Меняется запятая на точку.
        /// </summary>
        /// <param name="str">сточка из текстбокса.</param>
        /// <returns>Правильная сторка.</returns>
        internal static string DotToComma(this string str)
        {
            return str.Replace(".", ",");
        }
    }
}
