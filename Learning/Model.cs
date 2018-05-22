using System.Collections.Generic;

namespace Learning
{
    public abstract class Model
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                configPath = null;
                name = value;
            }
        }

        private string configPath;
        public string ConfigPath
        {
            get
            {
                if (configPath == null)
                {
                    configPath = Name.Replace(" ", "_") + ".json"; ;
                }

                return configPath;
            }
        }

        public Model(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public abstract string GetAlgorithm();

        public abstract IEnumerable<string> Train(double[][] x, double[][] y);

        public abstract double[][] Predict(double[][] x);

        public virtual void DumpParameters(Dictionary<string, object> parameters)
        {
            parameters["Name"] = Name;
            parameters["Algorithm"] = GetAlgorithm();
        }

        public abstract void LoadParameters(Dictionary<string, object> parameters);
    }
}
