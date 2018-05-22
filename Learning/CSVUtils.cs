using System;
using System.IO;

namespace Learning
{
    class CSVUtils
    {
        public static void WriteMatrix(string path, double[][] matrix)
        {
            using (var file = new StreamWriter(path))
            {
                foreach (var row in matrix)
                {
                    string line = JoinDoubles(",", row);
                    file.WriteLine(line);
                }
            }
        }

        public static double[][] ReadMatrix(string path)
        {
            var text = File.ReadAllText(path);
            var parts = text.Split(',');
            var predictions = new double[parts.Length][];

            for (int i = 0; i < parts.Length; i++)
            {
                predictions[i] = new double[] { double.Parse(parts[i],
                    System.Globalization.CultureInfo.InvariantCulture) };
            }

            return predictions;
        }

        public static string JoinDoubles(string separator, double[] values)
        {
            string buffer = "";

            for (int i = 0; i < values.Length; i++)
            {
                if (i > 0)
                {
                    buffer += separator;
                }

                buffer += values[i].ToString(System.Globalization.CultureInfo.InvariantCulture);
            }

            return buffer;
        }
    }
}
