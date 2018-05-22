using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MathUtils
    {
        public static double[][] Sub(double[][] x, double[][] y)
        {
            var result = new double[x.Length][];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = new double[] { x[i][0] - y[i][0] };
            }

            return result;
        }

        public static double[] Sub(double[] x, double[] y)
        {
            var result = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] - y[i];
            }

            return result;
        }

        public static double[][] Abs(double[][] x)
        {
            var result = new double[x.Length][];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = new double[] { Math.Abs(x[i][0]) };
            }

            return result;
        }

        public static double SumOfSquares(double[] x, double y)
        {
            var sum = 0.0;

            foreach (var v in x)
            {
                sum += (v - y) * (v - y);
            }

            return sum;
        }

        public static double SumOfSquares(double[] x, double[] y)
        {
            var sum = 0.0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += (x[i] - y[i]) * (x[i] - y[i]);
            }

            return sum;
        }

        public static double[] Abs(double[] x)
        {
            var result = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = Math.Abs(x[i]);
            }

            return result;
        }

        static public double StandardDeviation(double[][] data, double mean)
        {
            double sum = 0;
            double total = data.Length * data[0].Length;

            foreach (var row in data)
            {
                foreach (var x in row)
                {
                    sum += (double)Math.Pow(x - mean, 2);
                }
            }

            return (double)(Math.Sqrt(sum / total));
        }

        static public double StandardDeviation(double[] data, double mean)
        {
            double sum = 0;
            double total = data.Length;

            foreach (var x in data)
            {
                sum += (double)Math.Pow(x - mean, 2);
            }

            return (double)(Math.Sqrt(sum / total));
        }

        static public double StandardDeviation(double[][] data)
        {
            return StandardDeviation(data, Mean(data));
        }

        static public double StandardDeviation(double[] data)
        {
            return StandardDeviation(data, Mean(data));
        }

        static public double[][] Round(double[][] data)
        {
            var result = new double[data.Length][];

            for (int i = 0; i < data.Length; i++)
            {
                result[i] = new double[] { Math.Round(data[i][0]) };
            }

            return result;
        }

        public static double[] Flatten(double[][] v)
        {
            var r = new double[v.Length];

            for (int i = 0; i < v.Length; i++)
            {
                r[i] = v[i][0];
            }

            return r;
        }

        static public double Mean(double[][] data)
        {
            var totalSum = SumMatrix(data);
            var totalData = data.Length * data[0].Length;
            return totalSum / totalData;
        }

        static public double Mean(double[] data)
        {
            var totalSum = SumVector(data);
            var totalData = data.Length;
            return totalSum / totalData;
        }

        static public double SumMatrix(double[][] data)
        {
            double sum = 0;

            foreach (var row in data)
            {
                sum += row.Sum();
            }

            return sum;
        }

        static public double SumVector(double[] data)
        {
            return data.Sum();
        }

        public static double[][] Mul(double[][] x, int v)
        {
            var result = new double[x.Length][];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = new double[x[i].Length];

                for (int j = 0; j < x[i].Length; j++)
                {
                    result[i][j] = x[i][j] * v;
                }
            }

            return result;
        }

        public static double[] Mul(double[] x, int v)
        {
            var result = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] * v;
            }

            return result;
        }

        public static double[][] Div(double[][] x, double[][] y)
        {
            var result = new double[x.Length][];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = new double[x[i].Length];

                for (int j = 0; j < x[i].Length; j++)
                {
                    result[i][j] = x[i][j] / y[i][j];
                }
            }

            return result;
        }

        public static double[] Div(double[] x, double[] y)
        {
            var result = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] / y[i];
            }

            return result;
        }

        public static double Min(double[][] x)
        {
            var result = x[0][0];

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    if (x[i][j] < result)
                    {
                        result = x[i][j];
                    }
                }
            }

            return result;
        }


        public static double Min(double[] x)
        {
            var result = x[0];

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < result)
                {
                    result = x[i];
                }
            }

            return result;
        }

        public static double Max(double[][] x)
        {
            var result = x[0][0];

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    if (x[i][j] > result)
                    {
                        result = x[i][j];
                    }
                }
            }

            return result;
        }

        public static double Max(double[] x)
        {
            var result = x[0];

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > result)
                {
                    result = x[i];
                }
            }

            return result;
        }
    }
}
