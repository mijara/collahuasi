using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MockModel : Model
    {
        public MockModel(string name) : base(name)
        {

        }

        public override string GetAlgorithm()
        {
            return Algorithms.Mock;
        }

        public override double[][] Predict(double[][] x)
        {
            return null;
        }

        public override IEnumerable<string> Train(double[][] x, double[][] y)
        {
            System.Threading.Thread.Sleep(1000);
            yield return "output 1";
            System.Threading.Thread.Sleep(1000);
            yield return "output 2";
            System.Threading.Thread.Sleep(1000);
            yield return "output 3";
            System.Threading.Thread.Sleep(1000);
            yield return "output 4";
        }

        public override void DumpParameters(Dictionary<string, object> parameters)
        {
        }

        public override void LoadParameters(Dictionary<string, object> parameters)
        {
        }
    }
}
