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
    //TODO: XML +
    /// <summary>
    /// Класс FilterForm.
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Словарь видов элементов.
        /// </summary>
        private readonly Dictionary<string, Type> _elementTypes = new()
        {
            {nameof(Resistor), typeof(Resistor)},
            {nameof(Capacitor), typeof(Capacitor)},
            {nameof(InductorCoil), typeof(InductorCoil)}
        };

        /// <summary>
        /// Словарь названий элементов.
        /// </summary>
        private readonly Dictionary<string, string> _listBoxToElementType;

        /// <summary>
        /// Возвращает или устанавливает свойство поля EventHandler _elementListFiltered.
        /// </summary>
        public EventHandler<ElementEventArgsList> ElementListFiltered { get; set; }

        //TODO: encapsulation +
        /// <summary>
        /// Возврат или установка BindingList для MainForm _elementList.
        /// </summary>
        protected BindingList<PassiveElementBase> ElementList { get; set; }

        /// <summary>
        /// Конструктор фильтра.
        /// </summary>
        public FilterForm()
        {
            InitializeComponent();

            _listBoxToElementType = new Dictionary<string, string>()
            {
                {"Resistor", nameof(Resistor)},
                {"Capacitor", nameof(Capacitor)},
                {"InductorCoil", nameof(InductorCoil)}
            };
            ElementCheckedListBox.Items.AddRange
                (_listBoxToElementType.Keys.ToArray());
            OKbutton.Enabled = false;
        }
        /// <summary>
        /// Информация для DataGrid.
        /// </summary>
        /// <param name="sender">OK.</param>
        /// <param name="e">Аргумент.</param>
        private void OKbutton_Click(object sender, EventArgs e)
        {
            var valueFilteredList = new BindingList<PassiveElementBase>();
            var typeFilteredList = new BindingList<PassiveElementBase>();

            var action = new List<Action<BindingList<PassiveElementBase>>>
            {
                typeFilteredList =>
                {
                    foreach (var element in ElementList)
                    {
                        foreach (var checkedElement in
                                 ElementCheckedListBox.CheckedItems)
                        {
                            if (element.GetType() ==
                                _elementTypes[_listBoxToElementType
                                [checkedElement.ToString()]])
                            {

                                typeFilteredList.Add(element);
                            }
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Закрыть.
        /// </summary>
        /// <param name="sender">Закрыть.</param>
        /// <param name="e">Аргумент.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            var eventArgs = new ElementEventArgsList(ElementList);
            ElementListFiltered?.Invoke(this, eventArgs);

            Close();
        }

        /// <summary>
        /// Изменение информации в CheckedListBox.
        /// </summary>
        /// <param name="sender"> Выбранные элементы.</param>
        /// <param name="e">Аргументы.</param>
        private void ElementCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OKbutton.Enabled = true;
        }
    }
}
