using System.ComponentModel;
using Model;
using System.Xml.Serialization;

namespace View
{
    /// <summary>
    /// Класс MainForm.
    /// </summary>
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

        /// <summary>
        /// Класс MainForm.
        /// </summary>
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
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var newAddForm = new AddForm();

            newAddForm.Show();

            newAddForm.ElementEventHandler += (_, args) =>
            {
                _elementList.Add(args.PassiveElement);
                ElementDataGridView.DataSource = _elementList;
            };

            newAddForm.Closed += (_, _) =>
            {
                ButtonAdd.Enabled = true;
            };

            ButtonAdd.Enabled = false;
        }

        /// <summary>
        /// Нажатие на кнопку "удаление" элемемента в списоке.
        /// </summary>
        /// <param name="sender">Кнопка удалить.</param>
        /// <param name="e">Аргумент.</param>
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (ElementDataGridView.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in
                    ElementDataGridView.SelectedRows)
                {
                    _ = _elementList.Remove
                        (row.DataBoundItem as PassiveElementBase);

                    _ = _filteredList.Remove
                        (row.DataBoundItem as PassiveElementBase);
                }
            }
        }

        /// <summary>
        /// Нажатие на кнопку "очистить" список.
        /// </summary>
        /// <param name="sender">Кнопка очистить.</param>
        /// <param name="e">Аргумент.</param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            _elementList.Clear();
            _filteredList.Clear();
        }

        /// <summary>
        /// Нажатие на кнопку "фильтр" списока.
        /// </summary>
        /// <param name="sender">Кнопка фильтр.</param>
        /// <param name="e">Аргумент.</param>
        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm(_elementList);

            newFilterForm.Show();

            newFilterForm.ElementListFiltered += (_, args) =>
            {
                ElementDataGridView.DataSource = args.ElementListFiltered;
                _elementList = args.ElementListFiltered;
            };

            newFilterForm.Closed += (_, _) =>
            {
                ButtonFilter.Enabled = true;
            };

            ButtonFilter.Enabled = false;
        }

        /// <summary>
        /// Нажатие на кнопку "Open".
        /// </summary>
        /// <param name="sender">Кнопка Open.</param>
        /// <param name="e">Аргумент.</param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileBrowser = new OpenFileDialog
            {
                Filter = "PassiveElement (*.elmt)|*.elmt"
            };

            _ = fileBrowser.ShowDialog();
            var path = fileBrowser.FileName;

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            var xmlSerializer =
                new XmlSerializer(typeof(BindingList<PassiveElementBase>));

            try
            {
                using (var file = new StreamReader(path))
                {
                    _elementList = (BindingList<PassiveElementBase>)
                        xmlSerializer.Deserialize(file);
                }

                ElementDataGridView.DataSource = _elementList;
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Файл не может быть открыт.\n" + ex.Message,
                    "Файл поврежден или имеет неверный формат.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Save".
        /// </summary>
        /// <param name="sender">Кнопка Save.</param>
        /// <param name="e">Аргумент.</param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileBrowser = new SaveFileDialog
            {
                Filter = "PassiveElement (*.elmt)|*.elmt"
            };

            _ = fileBrowser.ShowDialog();
            var path = fileBrowser.FileName;

            var xmlSerializer =
                new XmlSerializer(typeof(BindingList<PassiveElementBase>));

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            using (var file = File.Create(path))
            {
                xmlSerializer.Serialize(file, ElementDataGridView.DataSource);
                file.Close();
            }
        }
    }
}
