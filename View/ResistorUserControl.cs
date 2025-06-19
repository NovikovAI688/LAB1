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
    /// Класс ResistorUserControl.
    /// </summary>
    public partial class ResistorUserControl : ElementBaseUserControl
    {
        /// <summary>
        /// ResistorUserControl конструктор.
        /// </summary>
        public ResistorUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Элемент.
        /// </summary>
        /// <returns>Элемент.</returns>
        public override PassiveElementBase GetElement()
        {
            var newResistor = new Resistor();

            var actions = new List<Action>()
            {
                () =>
                {
                    newResistor.Resistance =
                    Convert.ToDouble(resistanceTextBox.Text.DotToComma());
                }
            };

            InputParameters(actions);

            return newResistor;
        }
    }
}
