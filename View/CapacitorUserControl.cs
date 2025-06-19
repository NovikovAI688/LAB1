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
    public partial class CapacitorUserControl : UserControl
    {
        /// <summary>
        /// CapacitorUserControl instance constructor.
        /// </summary>
        public CapacitorUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get passive element object.
        /// </summary>
        /// <returns>Passive Element.</returns>
        public override PassiveElementBase GetElement()
        {
            var newCapacitor = new Capacitor();

            var actions = new List<Action>()
            {
                () =>
                {
                    newCapacitor.Capacity = Convert.ToDouble
                    (textBoxCapacity.Text.DotToComma());
                },
                () =>
                {
                    newCapacitor.Frequency = Convert.ToDouble
                    (textBoxFrequency.Text.DotToComma());
                }
            };

            InputParameters(actions);

            return newCapacitor;
        }
    }
}
