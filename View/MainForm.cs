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
            var newEnterForm = new AddForm();

            newEnterForm.Show();

            newEnterForm.ElementEventHandler += (_, args) =>
            {
                _elementList.Add(args.PassiveElement);
                ElementDataGridView.DataSource = _elementList;
            };

            newEnterForm.Closed += (_, _) =>
            {
                buttonAdd.Enabled = true;
            };

            buttonAdd.Enabled = false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _elementList.Clear();
            _filteredList.Clear();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm();

            newFilterForm.ElementList = _elementList;

            newFilterForm.Show();

            newFilterForm.ElementListFiltered += (_, args) =>
            {
                ElementDataGridView.DataSource = args.ElementListFiltered;
                _elementList = args.ElementListFiltered;
            };

            newFilterForm.Closed += (_, _) =>
            {
                buttonFilter.Enabled = true;
            };

            buttonFilter.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
            catch (Exception)
            {
                _ = MessageBox.Show("Файл не может быть открыт.\n",
                    "Файл поврежден или имеет неверный формат.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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
