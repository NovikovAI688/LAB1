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
    /// Dictionary of UserControls.
    /// </summary>
    private readonly Dictionary<string,
        UserControl> _comboBoxToUserControl;

    /// <summary>
    /// Gets or sets EventHandler _elementEventHandler field's property.
    /// </summary>
    public EventHandler<ElementEventArgs> ElementEventHandler;
    public partial class AddForm : Form
    {
        /// <summary>
        /// AddForm.
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
#if DEBUG
            buttonAddRandomElement.Visible = true;
#endif

            string[] elementTypes = { "Resistor", "Capacitor", "InductorCoil" };
            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {elementTypes[0], resistorUserControl1},
                {elementTypes[1], capacitorUserControl1},
                {elementTypes[2], inductorCoilUserControl1},
            };

            ElementTypesComboBox_SelectedIndexChanged.Items.AddRange(elementTypes);

            ElementTypesComboBox_SelectedIndexChanged.SelectedIndexChanged +=
                ElementTypesComboBox_SelectedIndexChanged;

            buttonOK.Enabled = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ElementTypesComboBox.Text.ToString()))
            {
                Close();
            }
            else
            {
                try
                {
                    var selectedElement =
                        ElementTypesComboBox.SelectedItem.ToString();

                    var selectedElementControl =
                        _comboBoxToUserControl[selectedElement];

                    var eventArgs = new ElementEventArgs
                        (((ElementBaseUserControl)
                        selectedElementControl).GetElement());

                    ElementEventHandler?.Invoke(this, eventArgs);
                }
                catch (Exception exception)
                {
                    if (exception.GetType() == typeof
                        (ArgumentOutOfRangeException) ||
                        exception.GetType() == typeof
                        (FormatException) ||
                        exception.GetType() == typeof
                        (ArgumentException))
                    {
                        _ = MessageBox.Show
                            ($"Неверно введены параметры.\n" +
                            $"Ошибка: {exception.Message}");
                    }
                    else
                    {
                        throw;
                    }
                }
            }

        }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddRandomElement_Click(object sender, EventArgs e)
        {

        }

        private void ElementTypesComboBox_SelectedIndexChanged_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedElement =
                ElementTypesComboBox.SelectedItem.ToString();

            OKButton.Enabled = true;

            foreach (var (key, value) in _comboBoxToUserControl)
            {
                value.Visible = false;
                if (selectedElement == key)
                {
                    value.Visible = true;
                }
            }
        }
    }
}
