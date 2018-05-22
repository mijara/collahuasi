using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Learning
{
    public partial class Main : Form
    {
        private Dictionary<string, int> modelPointers = new Dictionary<string, int>();

        private DataHandler dataHandler;

        public Main()
        {
            InitializeComponent();
            LoadModels();
        }

        private void LoadModels()
        {
            string[] files = Directory.GetFiles(".", "*.json");

            foreach (var fileName in files)
            {
                var json = File.ReadAllText(fileName);
                var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

                var name = (string)data["Name"];
                var algorithm = (string)data["Algorithm"];

                var model = Algorithms.CreateFromString(algorithm, name);
                model.LoadParameters(data);
                RegisterModel(model);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new TrainingDialog();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var m = new ModelCreator())
            {
                var result = m.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var model = m.Model;

                    RegisterModel(model);
                }
            }
        }

        private void RegisterModel(Model model)
        {
            if (modelPointers.ContainsKey(model.Name))
            {
                var index = modelPointers[model.Name];
                modelsListBox.Items.RemoveAt(index);
                modelsListBox.Items.Insert(index, model);
            }
            else
            {
                modelPointers[model.Name] = modelsListBox.Items.Count;
                modelsListBox.Items.Add(model);
            }
        }

        private void modelsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (modelsListBox.SelectedItem != null)
            {
                var model = (Model)modelsListBox.SelectedItem;

                using (var m = new ModelCreator())
                {
                    m.PopulateWithModel(model);
                    var result = m.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        RegisterModel(m.Model);
                    }
                }
            }
        }

        private void datasetSelectButton_Click(object sender, EventArgs e)
        {
            datasetOpenFileDialog.Filter = "csv files (*.csv)|*.csv";

            var result = datasetOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataHandler = DataHandler.ReadCSV(datasetOpenFileDialog.FileName);
                UpdateFeaturesCheckBoxList();
                UpdateTargetCheckBoxList();

                datasetPathTextBox.Text = datasetOpenFileDialog.FileName;
            }
        }

        private void UpdateFeaturesCheckBoxList()
        {
            featuresCheckBoxList.Items.Clear();

            foreach (var column in dataHandler.Columns)
            {
                featuresCheckBoxList.Items.Add(column);
            }
        }

        private void UpdateTargetCheckBoxList()
        {
            targetComboBoxList.Items.Clear();

            foreach (var column in dataHandler.Columns)
            {
                targetComboBoxList.Items.Add(column);
            }
        }

        private void trainModelButton_Click(object sender, EventArgs e)
        {
            var model = (Model)modelsListBox.SelectedItem;
            if (model == null)
            {
                MessageBox.Show("Debe seleccionar un modelo de la lista", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var features = ExtractFeaturesFromCheckBoxList();
            if (features.Length == 0)
            {
                MessageBox.Show("Debe seleccionar las features de entrenamiento", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var target = (string)targetComboBoxList.SelectedItem;
            if (target == null)
            {
                MessageBox.Show("Debe seleccionar el target de entrenamiento", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var trainingPercentage = (int)trainingPercentageNumericUpDown.Value;

            var job = new TrainingJob
            {
                Model = model,
                Features = features,
                Target = target,
                DataHandler = dataHandler,
                TrainingPercentage = trainingPercentage
            };

            using (var m = new TrainingDialog())
            {
                m.Job = job;

                switch (m.ShowDialog())
                {
                    case DialogResult.OK:
                        DisplayResults(job);
                        break;
                    case DialogResult.Cancel:
                        MessageBox.Show("Entrenamiento cancelado.");
                        break;
                }
            }
        }

        private string[] ExtractFeaturesFromCheckBoxList()
        {
            var features = new string[featuresCheckBoxList.CheckedItems.Count];
            
            for (int i = 0; i < features.Length; i++)
            {
                features[i] = (string)featuresCheckBoxList.CheckedItems[i];
            }

            return features;
        }

        private void DisplayResults(TrainingJob job)
        {
            job.Predict();

            var validator = new Validator(job);

            PropulatePredictionsListBox(validator.TestY, validator.PredY, validator.PercentualError.Values);
            PopulateResumeGroupBox(validator.PercentualError);

            // change tab to display results.
            tabControl.SelectedTab = tabControl.TabPages[1];
        }

        private void PopulateResumeGroupBox(Validator.ErrorStats errors)
        {
            var table = new TableLayoutPanel();
            table.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            table.AutoSize = true;

            AddResumeTableRow(table, 0, "MAE", errors.AbsMean.ToString("0.00") + "%");
            AddResumeTableRow(table, 1, "STD", errors.Std.ToString("0.00") + "%");
            AddResumeTableRow(table, 2, "Mínimo", errors.Minimum.ToString("0.00") + "%");
            AddResumeTableRow(table, 3, "25%", errors.Percent25.ToString("0.00") + "%");
            AddResumeTableRow(table, 4, "50%", errors.Percent50.ToString("0.00") + "%");
            AddResumeTableRow(table, 5, "75%", errors.Percent75.ToString("0.00") + "%");
            AddResumeTableRow(table, 6, "Máximo", errors.Maximum.ToString("0.00") + "%");

            resumePanel.Controls.Add(table);
        }

        private void AddResumeTableRow(TableLayoutPanel table, int row, string text, string data)
        {
            var textLabel = new Label();
            textLabel.Text = text;
            table.Controls.Add(textLabel, 0, row);

            var dataLabel = new Label();
            dataLabel.Text = data;
            table.Controls.Add(dataLabel, 1, row);
        }

        private void PropulatePredictionsListBox(double[] testY, double[] predY, double[] error)
        {
            predictionsListView.Items.Clear();

            for (int i = 0; i < testY.Length; i++)
            {
                predictionsListView.Items.Add(((int)testY[i]).ToString()).
                    SubItems.AddRange(new string[] {
                        ((int)predY[i]).ToString(),
                        ((int)error[i]).ToString(),
                    });
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            MinimumSize = new System.Drawing.Size(900, 600);
            Size = new System.Drawing.Size(900, 600);
        }
    }
}
