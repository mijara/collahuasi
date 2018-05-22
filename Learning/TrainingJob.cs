using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class TrainingJob
    {
        public Model Model;
        public string[] Features;
        public string Target;
        public DataHandler DataHandler;
        public int TrainingPercentage;

        public DataHandler TrainingData;
        public DataHandler TestData;
        public StandardScaler Scaler;

        public double[][] Predictions;

        public int TrainingSize
        {
            get
            {
                return DataHandler.Count * TrainingPercentage / 100;
            }
        }

        public int TestSize
        {
            get
            {
                return DataHandler.Count * (100 - TrainingPercentage) / 100;
            }
        }

        public void PrepareModelConfig(string mode)
        {
            var parameters = new Dictionary<string, object>();

            Model.DumpParameters(parameters);

            var json = JsonConvert.SerializeObject(parameters);

            File.WriteAllText(Model.ConfigPath, json);
        }

        public void Predict()
        {
            Predictions = Model.Predict(TestData.AsArray(Target));
        }

        public IEnumerable<string> Train()
        {
            PrepareModelConfig("Train");

            Scaler = new StandardScaler();

            DataHandler.Shuffle();
            TrainingData = DataHandler.Slice(0, TrainingPercentage / 100.0F);
            TestData = DataHandler.Slice(TrainingPercentage / 100.0F, 1);

            var x = TrainingData.AsArray(Features);
            var y = TrainingData.AsArray(Target);

            Scaler.Fit(x);
            x = Scaler.Transform(x);

            foreach (var line in Model.Train(x, y))
            {
                yield return line;
            }
        }
    }
}
