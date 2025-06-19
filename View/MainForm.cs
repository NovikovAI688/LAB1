using System.ComponentModel;
using Model;
using System.Xml.Serialization;

namespace View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список элементов.
        /// </summary>
        private BindingList<PassiveElementBase> _elementList = new BindingList<PassiveElementBase>();

        /// <summary>
        /// Отфильтрованный список элементов.
        /// </summary>
        private BindingList<PassiveElementBase> _filteredList = new BindingList<PassiveElementBase>();
        public MainForm()
        {
            InitializeComponent();

            var source = new BindingSource(_elementList, null);
            ElementDataGridView.DataSource = source;
        }

        /// <summary>
        /// Нажатие на кнопку "добавление" элемемента в список.
        /// </summary>
        /// <param name="sender">Кнопка добавить.</param>
        /// <param name="e">Аргумент.</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var newEnterForm = new EnterForm();

            newEnterForm.Show();

            newEnterForm.ElementEventHandler += (_, args) =>
            {
                _elementList.Add(args.PassiveElement);
                ElementDataGridView.DataSource = _elementList;
            };

            newEnterForm.Closed += (_, _) =>
            {
                ButtonAdd.Enabled = true;
            };

            ButtonAdd.Enabled = false;
        }


    }
}
