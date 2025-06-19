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
    public partial class AddForm : Form
    {
        /// <summary>
        /// Словарь для UserControls.
        /// </summary>
        private readonly Dictionary<string,
            UserControl> _comboBoxToUserControl;

        /// <summary>
        /// Возвращает или устанавливает свойство поля EventHandler _elementEventHandler.
        /// </summary>
        public EventHandler<ElementEventArgs> ElementEventHandler { get; set; }

        /// <summary>
        /// Форма AddForm.
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

            ElementTypesComboBox.Items.AddRange(elementTypes);

            ElementTypesComboBox.SelectedIndexChanged +=
                ElementTypesComboBox_SelectedIndexChanged;

            buttonOK.Enabled = false;
        }

        /// <summary>
        /// Добавление нового элемента.
        /// </summary>
        /// <param name="sender">ОК.</param>
        /// <param name="e">Аргумент.</param>
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

        /// <summary>
        /// Закрыть форму.
        /// </summary>
        /// <param name="sender">Закрыть кнопка.</param>
        /// <param name="e">Аргумент.</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление рандомного элемента.
        /// </summary>
        /// <param name="sender">Кнопка рандома.</param>
        /// <param name="e">Аргумент.</param>
        private void buttonAddRandomElement_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            var elementTypes = new Dictionary<int, PassiveElementType>
            {
                {0, PassiveElementType.Resistor },
                {1, PassiveElementType.Capacitor },
                {2, PassiveElementType.InductorCoil}
            };

            var randomType = random.Next(elementTypes.Count);
            var randomElement =
                new RandomPassiveElement()
                .GetRandomParameters(elementTypes[randomType]);
            var eventArgs = new ElementEventArgs(randomElement);
            ElementEventHandler?.Invoke(this, eventArgs);
        }

        /// <summary>
        /// Посмотреть содержимое (изменение) комбобокса.
        /// </summary>
        /// <param name="sender">Виды элемента.</param>
        /// <param name="e">Аргумент.</param>
        private void ElementTypesComboBox_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            string selectedElement =
                ElementTypesComboBox.SelectedItem.ToString();

            buttonOK.Enabled = true;

            foreach (var (key, value) in _comboBoxToUserControl)
            {
                value.Visible = false;
                if (selectedElement == key)
                {
                    value.Visible = true;
                }
            }
        }

        /// <summary>
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender">AddForm.</param>
        /// <param name="e">Аргумент.</param>
        private void EnterForm_Load(object sender, EventArgs e)
        {
            resistorUserControl1.Visible = false;
            capacitorUserControl1.Visible = false;
            inductorCoilUserControl1.Visible = false;
        }
    }
}
