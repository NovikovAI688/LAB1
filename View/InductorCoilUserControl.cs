using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс InductorCoilUserControl.
    /// </summary>
    public partial class InductorCoilUserControl : ElementBaseUserControl
    {
        /// <summary>
        /// ImpedanceUserControl конструктор.
        /// </summary>
        public InductorCoilUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public override PassiveElementBase GetElement()
        {
            var newInductorCoil = new InductorCoil();

            var actions = new List<Action>()
            {
                () =>
                {
                    newInductorCoil.Inductance =
                    Convert.ToDouble(textBoxInductance.Text.DotToComma());
                },
                () =>
                {
                    newInductorCoil.Frequency =
                    Convert.ToDouble(textBoxFrequency.Text.DotToComma());
                }
            };

            InputParameters(actions);

            return newInductorCoil;
        }
    }
}
