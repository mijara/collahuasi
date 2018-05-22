using System;
using System.Collections.Generic;
using System.IO;

namespace Learning
{
    public class DataHandler
    {
        public List<string> Columns = new List<string>();
        private List<List<double>> rows = new List<List<double>>();
        private List<int> ignoreIndices = new List<int>();

        public int Count
        {
            get
            {
                return rows.Count;
            }
        }

        public DataHandler Slice(double from, double to)
        {
            var result = new DataHandler();
            result.ReadHeader(Columns.ToArray());

            var fromIndex = (int)(from * rows.Count);
            var toIndex = (int)(to * rows.Count);

            for (int i = fromIndex; i < toIndex; i++)
            {
                result.AddRow(rows[i]);
            }

            return result;
        }

        public double[][] AsArray()
        {
            var matrix = new double[rows.Count][];

            for (int i = 0; i < rows.Count; i++)
            {
                var row = rows[i];

                matrix[i] = new double[row.Count];

                for (int j = 0; j < row.Count; j++)
                {
                    matrix[i][j] = row[j];
                }
            }

            return matrix;
        }

        public void Shuffle()
        {
            var random = new Random();

            int n = rows.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var value = rows[k];
                rows[k] = rows[n];
                rows[n] = value;
            }
        }

        public double[][] AsArray(params string[] parts)
        {
            var indices = new List<int>();

            for (int i = 0; i < parts.Length; i++)
            {
                int index = Columns.IndexOf(parts[i]);

                if (index < 0)
                {
                    throw new IndexOutOfRangeException("column not found: " + parts[i]);
                }

                indices.Add(index);
            }

            var result = new double[rows.Count][];

            for (int r = 0; r < result.Length; r++)
            {
                var row = rows[r];
                result[r] = new double[indices.Count];

                for (int c = 0; c < indices.Count; c++)
                {
                    result[r][c] = rows[r][indices[c]];
                }
            }

            return result;
        }

        public int GetSize()
        {
            return rows.Count;
        }

        public static DataHandler ReadCSV(string file)
        {
            var dataHandler = new DataHandler();
            var readHeader = true;

            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');

                    if (readHeader)
                    {
                        dataHandler.ReadHeader(parts);
                        readHeader = false;
                    }
                    else
                    {
                        dataHandler.AddRow(parts);
                    }
                }
            }

            return dataHandler;
        }

        private void ReadHeader(string[] parts)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] != "")
                {
                    Columns.Add(parts[i]);
                }
                else
                {
                    ignoreIndices.Add(i);
                }
            }
        }

        private void AddRow(string[] parts)
        {
            var row = new List<double>();

            for (int i = 0; i < parts.Length; i++)
            {
                if (!ignoreIndices.Contains(i))
                {
                    row.Add(double.Parse(parts[i], 
                        System.Globalization.CultureInfo.InvariantCulture));
                }
            }

            rows.Add(row);
        }

        private void AddRow(List<double> parts)
        {
            var row = new List<double>();

            for (int i = 0; i < parts.Count; i++)
            {
                row.Add(parts[i]);
            }

            rows.Add(row);
        }

        public static void DebugArray(double[][] array)
        {
            var format = "";
            for (int i = 0; i < array[0].Length; i++)
            {
                format += "{" + i + "} ";
            }

            var row = new string[array[0].Length];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    row[j] = String.Format("{0:000.00;-0000000.00}", array[i][j]);
                }

                Console.WriteLine(String.Format(format, row));
            }
        }
    }
}