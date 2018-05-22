using System;
using System.Windows.Forms;

namespace Learning
{
    public partial class ModelCreator : Form
    {
        private ModelPropertiesControl modelPropertiesForm;

        public Model Model;

        public ModelCreator()
        {
            InitializeComponent();

            foreach (var algorithm in Algorithms.GetAll())
            {
                algorithmComboBox.Items.Add(algorithm);
            }
        }

        private void algorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var algorithm = algorithmComboBox.Items[algorithmComboBox.SelectedIndex];

            Control propertiesControl = null;

            switch (algorithm)
            {
                case Algorithms.MultiLayerPerceptron:
                    propertiesControl = new MultiLayerPerceptronModelPropertiesControl();
                    break;
                case Algorithms.Mock:
                    propertiesControl = new MockModelPropertiesControl();
                    break;
            }

            if (propertiesControl == null)
            {
                return;
            }

            modelPropertiesForm = (ModelPropertiesControl)propertiesControl;

            propertiesControl.Visible = true;

            propertiesPanel.Controls.Add(propertiesControl);

            if (Model != null)
            {
                modelPropertiesForm.Populate(Model);
            }

            // TODO: this needs some work...
            this.Height = 400;
        }

        private void saveModelButton_Click(object sender, EventArgs e)
        {
            var name = modelNameTextBox.Text;
            Model = modelPropertiesForm.GenerateModel(name);

            DialogResult = DialogResult.OK;
            Close();
        }

        public void PopulateWithModel(Model model)
        {
            Model = model;
            algorithmComboBox.SelectedIndex = Algorithms.FindIndex(model.GetAlgorithm());
            modelNameTextBox.Text = model.Name;
        }
    }
}
