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

        //TODO: encapsulation
        /// <summary>
        /// Возврат или установка BindingList для MainForm _elementList.
        /// </summary>
        public BindingList<PassiveElementBase> ElementListBase { private get; set; }

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

        //TODO: refactoring +
        /// <summary>
        /// Информация для DataGrid.
        /// </summary>
        /// <param name="sender">OK.</param>
        /// <param name="e">Аргумент.</param>
        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (!TryGetSearchValue(out double searchValue))
            {
                return;
            }

            var typeFilteredList = GetTypeFilteredElements();
            var valueFilteredList = GetValueFilteredElements(typeFilteredList, searchValue);

            var eventArgs = string.IsNullOrEmpty(searchValue.ToString())
                ? new ElementEventArgsList(typeFilteredList)
                : new ElementEventArgsList(valueFilteredList);

            ElementListFiltered?.Invoke(this, eventArgs);
        }

        /// <summary>
        /// Поиск значения.
        /// </summary>
        private bool TryGetSearchValue(out double searchValue)
        {
            var input = SearchTextBox.Text.DotToComma();
            var isValid = double.TryParse(input, out searchValue);

            if (!string.IsNullOrEmpty(input) && !isValid)
            {
                MessageBox.Show("Введенное значение некорректного формата!");
                SearchTextBox.Clear();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Элементы GetTypeFilteredElements.
        /// </summary>
        private BindingList<PassiveElementBase> GetTypeFilteredElements()
        {
            var typeFilteredList = new BindingList<PassiveElementBase>();

            foreach (var checkedElement in ElementCheckedListBox.CheckedItems)
            {
                var elementType = _elementTypes[_listBoxToElementType[checkedElement.ToString()]];

                foreach (var element in ElementListBase)
                {
                    if (element.GetType() == elementType)
                    {
                        typeFilteredList.Add(element);
                    }
                }
            }

            return typeFilteredList.Count > 0 ? typeFilteredList : ElementListBase;
        }

        /// <summary>
        /// Получить значения элементов GetTypeFilteredElements.
        /// </summary>
        private BindingList<PassiveElementBase> GetValueFilteredElements(BindingList<PassiveElementBase> typeFilteredList, double searchValue)
        {
            var valueFilteredList = new BindingList<PassiveElementBase>();

            foreach (var element in typeFilteredList)
            {
                if (element.Impedance.Contains(searchValue.ToString()))
                {
                    valueFilteredList.Add(element);
                }
            }

            return valueFilteredList;
        }

        /// <summary>
        /// Закрыть.
        /// </summary>
        /// <param name="sender">Закрыть.</param>
        /// <param name="e">Аргумент.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            var eventArgs = new ElementEventArgsList(ElementListBase);
            ElementListFiltered?.Invoke(this, eventArgs);

            if (!string.IsNullOrEmpty(SearchTextBox.Text.DotToComma()))
            {
                SearchTextBox.Clear();
            }
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
