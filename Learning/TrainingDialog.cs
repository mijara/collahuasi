using System;
using System.Windows.Forms;

namespace Learning
{
    public partial class TrainingDialog : Form
    {
        public TrainingJob Job { get; set; }

        public TrainingDialog()
        {
            InitializeComponent();
        }

        private void TrainingDialog_Load(object sender, EventArgs e)
        {
            titleTextBox.Text = "Entrenando modelo: " + Job.Model.Name;

            WriteLine("Features:", string.Join(", ", Job.Features));
            WriteLine("Target:", Job.Target);
            WriteLine("Porcentaje de entramiento:", Job.TrainingPercentage.ToString());
            WriteLine("Samples para entrenamiento:", Job.TrainingSize.ToString());
            WriteLine("Samples para validación:", Job.TestSize.ToString());

            trainingBackgroundWorker.RunWorkerAsync();
        }
        
        private void WriteLine(params string[] text)
        {
            try
            {
                outputRichTextBox.AppendText(string.Join(" ", text) + "\n");
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            trainingBackgroundWorker.CancelAsync();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void trainingBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            foreach (var line in Job.Train())
            {
                trainingBackgroundWorker.ReportProgress(0, line);
            }
        }

        private void trainingBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void trainingBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                WriteLine((string)e.UserState);
            }
        }
    }
}
