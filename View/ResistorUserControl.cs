using Model;

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
        /// Элемент резистор.
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
