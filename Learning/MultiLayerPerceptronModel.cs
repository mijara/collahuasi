using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MultiLayerPerceptronModel : Model
    {
        public string Solver;
        public double Alpha;
        public int[] HiddenLayers;

        ProcessModel processModel;

        public MultiLayerPerceptronModel(string name) : base(name)
        {
            processModel = new ProcessModel(this, new ProcessModel.ProcessConfig()
            {
                ProcessPath = "python/venv/Scripts/python.exe",
                MainFile = "python/main.py",
                TrainFeaturesFile = "outputs/features.csv",
                TrainTargetFile = "outputs/target.csv",
                PredictFeaturesFile = "outputs/features.csv",
                PredictPredictionsFile = "outputs/predictions.csv",
            });
        }

        public override string GetAlgorithm()
        {
            return Algorithms.MultiLayerPerceptron;
        }

        public override IEnumerable<string> Train(double[][] x, double[][] y)
        {
            return processModel.Train(x, y);
        }

        public override double[][] Predict(double[][] x)
        {
            return processModel.Predict(x);
        }

        public override void DumpParameters(Dictionary<string, object> parameters)
        {
            base.DumpParameters(parameters);

            parameters["Solver"] = Solver;
            parameters["Alpha"] = Alpha;
            parameters["HiddenLayers"] = string.Join(",", HiddenLayers);
            processModel.Config.Dump(parameters);
        }

        public override void LoadParameters(Dictionary<string, object> parameters)
        {
            Solver = (string)parameters["Solver"];
            Alpha = (double)parameters["Alpha"];

            var hl = ((string)parameters["HiddenLayers"]).Split(',');
            HiddenLayers = new int[hl.Length];
            for (int i = 0; i < hl.Length; i++)
            {
                HiddenLayers[i] = int.Parse(hl[i]);
            }
        }
    }
}
