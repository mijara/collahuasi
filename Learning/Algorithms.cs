using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Algorithms
    {
        public const string Mock = "Mock";
        public const string MultiLayerPerceptron = "Multi Layer Perceptron";

        public static string[] GetAll()
        {
            return new string[]
            {
                Mock,
                MultiLayerPerceptron,
            };
        }

        public static int FindIndex(string algorithm)
        {
            switch (algorithm)
            {
                case MultiLayerPerceptron:
                    return 1;
                case Mock:
                    return 0;
            }

            return -1;
        }

        public static Model CreateFromString(string algorithm, string name)
        {
            switch (algorithm)
            {
                case MultiLayerPerceptron:
                    return new MultiLayerPerceptronModel(name);
                case Mock:
                    return new MockModel(name);
            }

            return null;
        }
    }
}
