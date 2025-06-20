using Model;

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
