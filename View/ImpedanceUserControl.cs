using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс ImpedanceUserControl.
    /// </summary>
    public partial class ImpedanceUserControl : UserControl
    {
        /// <summary>
        /// ImpedanceUserControl конструктор.
        /// </summary>
        public ImpedanceUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Комплексное число отфильтраванное.
        /// </summary>
        /// <returns>Complex.</returns>
        /// <exception cref="ArgumentException">
        /// Input string is empty.</exception>
        public Complex GetComplex()
        {
            double real = Convert.ToDouble
                (realTextBox.Text.DotToComma());

            double imaginary = Convert.ToDouble
                (imaginaryTextBox.Text.DotToComma());

            var newComplex = new Complex(real, imaginary);
            return newComplex;
        }
    }
}
