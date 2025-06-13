using System.ComponentModel;
using Model;

namespace View
{
    public partial class MainForm : Form
    {
        private BindingList<PassiveElementBase> _elementsCollection = new BindingList<PassiveElementBase>();
        public MainForm()
        {
            InitializeComponent();

            var bindingSource = new BindingSource();
            bindingSource.DataSource = _elementsCollection;
            dataGridView1.DataSource = bindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formAdd = new AddElements();
           // formAdd.PersonAdded = Form2_PersonAdded;
            formAdd.ShowDialog();
        }
    }
}
