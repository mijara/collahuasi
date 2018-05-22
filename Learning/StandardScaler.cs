using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class StandardScaler
    {
        private double mean;
        private double standardDeviation;

        public void Fit(double[][] data)
        {
            this.mean = MathUtils.Mean(data);
            this.standardDeviation = MathUtils.StandardDeviation(data, this.mean);
        }

        public double[][] Transform(double[][] data)
        {
            var res = new double[data.Length][];

            for (int row = 0; row < data.Length; row++)
            {
                res[row] = new double[data[row].Length];

                for (int col = 0; col < data[row].Length; col++)
                {
                    res[row][col] = (data[row][col] - mean) / standardDeviation;
                }
            }

            return res;
        }

        public double GetMean()
        {
            return mean;
        }

        public double GetStandardDeviation()
        {
            return standardDeviation;
        }
    }
}
