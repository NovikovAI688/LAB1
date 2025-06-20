using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    //TODO: XML
    public static class SingleView
    {
        /// <summary>
        /// Dot are chanded to comma.
        /// </summary>
        /// <param name="str">string from textbox.</param>
        /// <returns>Correct string.</returns>
        internal static string DotToComma(this string str)
        {
            return str.Replace(".", ",");
        }
    }
}
