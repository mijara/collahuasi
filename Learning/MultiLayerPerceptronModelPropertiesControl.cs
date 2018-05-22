using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning
{
    public partial class MultiLayerPerceptronModelPropertiesControl : UserControl, ModelPropertiesControl
    {
        public MultiLayerPerceptronModelPropertiesControl()
        {
            InitializeComponent();
        }

        public Model GenerateModel(string name)
        {
            string optimizer = (string)optimizerComboBox.SelectedItem;
            double alpha = double.Parse(alphaTextBox.Text);
            var hiddenLayers = new int[nnLayersListBox.Items.Count];

            for (int i = 0; i < hiddenLayers.Length; i++)
            {
                hiddenLayers[i] = (int)nnLayersListBox.Items[i];
            }

            var model = new MultiLayerPerceptronModel(name)
            {
                Solver = optimizer,
                Alpha = alpha,
                HiddenLayers = hiddenLayers
            };

            return model;
        }

        public void Populate(Model model)
        {
            if (!(model is MultiLayerPerceptronModel))
            {
                return;
            }

            var multiLayerPerceptron = (MultiLayerPerceptronModel)model;

            var optimizerIndex = optimizerComboBox.FindString(multiLayerPerceptron.Solver);
            optimizerComboBox.SelectedIndex = optimizerIndex;

            alphaTextBox.Text = multiLayerPerceptron.Alpha.ToString();

            foreach (var layer in multiLayerPerceptron.HiddenLayers)
            {
                nnLayersListBox.Items.Add(layer);
            }
        }

        private void nnAddLayerButton_Click(object sender, EventArgs e)
        {
            using (var m = new AddNNLayerDialog())
            {
                var result = m.ShowDialog();

                if (result == DialogResult.OK)
                {
                    nnLayersListBox.Items.Add(m.NNSize);
                }
            }
        }

        private void nnRemoveLayerButton_Click(object sender, EventArgs e)
        {
            var selected = nnLayersListBox.SelectedIndex;

            if (selected != -1)
            {
                nnLayersListBox.Items.RemoveAt(selected);
            }
        }
    }
}
