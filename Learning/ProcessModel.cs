using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Learning
{
    public class ProcessModel
    {
        public ProcessConfig Config;

        private Model model;

        public ProcessModel(Model model, ProcessConfig Config)
        {
            this.model = model;
            this.Config = Config;
            Config.StateFile = model.Name.Replace(" ", "_") + ".state";
        }

        public IEnumerable<string> Train(double[][] x, double[][] y)
        {
            CSVUtils.WriteMatrix(Config.TrainFeaturesFile, x);
            CSVUtils.WriteMatrix(Config.TrainTargetFile, y);
            return OpenCommunication("Train");
        }

        public double[][] Predict(double[][] x)
        {
            CSVUtils.WriteMatrix(Config.PredictFeaturesFile, x);

            foreach (var line in OpenCommunication("Predict"))
            {
                Console.WriteLine(line);
            }

            return CSVUtils.ReadMatrix(Config.PredictPredictionsFile);
        }

        private IEnumerable<string> OpenCommunication(string mode)
        {
            var processStartInfo = new ProcessStartInfo(Config.ProcessPath);
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.Arguments = Config.MainFile + " " + mode + " " + model.ConfigPath;
            processStartInfo.CreateNoWindow = true;

            var process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();

            var myStreamReader = process.StandardOutput;
            string line;
            while ((line = myStreamReader.ReadLine()) != null)
            {
                yield return line;
            }

            process.WaitForExit();
            process.Close();
        }

        public class ProcessConfig
        {
            public string ProcessPath;
            public string MainFile;

            public string TrainFeaturesFile;
            public string TrainTargetFile;
            public string PredictFeaturesFile;
            public string PredictPredictionsFile;
            public string StateFile;

            public void Dump(Dictionary<string, object> parameters)
            {
                parameters["TrainFeaturesFile"] = TrainFeaturesFile;
                parameters["TrainTargetFile"] = TrainTargetFile;
                parameters["PredictFeaturesFile"] = PredictFeaturesFile;
                parameters["PredictPredictionsFile"] = PredictPredictionsFile;
                parameters["StateFile"] = StateFile;
            }
        }
    }
}
