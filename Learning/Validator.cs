using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Validator
    {
        private TrainingJob job;

        public double[][] TrainX;
        public double[] TrainY;

        public double[][] TestX;
        public double[] TestY;
        public double[] PredY;

        public ANOVA ANOVA;

        public class ErrorStats
        {
            public double[] Values { get; internal set; }
            public double[] SortedValues { get; internal set; }

            public double Mean { get; internal set; }
            public double AbsMean { get; internal set; }
            public double Std { get; internal set; }

            public double Minimum { get; internal set; }
            public double Percent25 { get; internal set; }
            public double Percent50 { get; internal set; }
            public double Percent75 { get; internal set; }
            public double Maximum { get; internal set; }
        }

        public ErrorStats AbsoluteError = new ErrorStats();
        public ErrorStats PercentualError = new ErrorStats();

        public Validator(TrainingJob job)
        {
            this.job = job;

            TestX = job.TestData.AsArray(job.Features);
            TestX = job.Scaler.Transform(TestX);

            TestY = MathUtils.Flatten(job.TestData.AsArray(job.Target));
            PredY = MathUtils.Flatten(job.Predictions);

            PerformCalculations();
        }

        private void PerformCalculations()
        {
            CalculateAbsoluteError();
            CalculatePercentualError();

            CalculateErrorPercents(AbsoluteError);
            CalculateErrorPercents(PercentualError);

            ANOVA = new ANOVA(job);
        }

        private void CalculateAbsoluteError()
        {
            AbsoluteError.Values = MathUtils.Abs(MathUtils.Sub(TestY, PredY));
        }

        private void CalculatePercentualError()
        {
            PercentualError.Values = MathUtils.Div(
                MathUtils.Mul(AbsoluteError.Values, 100), 
                TestY
            );
        }

        private void CalculateErrorPercents(ErrorStats errors)
        {
            errors.SortedValues = new double[errors.Values.Length];
            Array.Copy(errors.Values, errors.SortedValues, errors.Values.Length);
            Array.Sort(errors.SortedValues);

            errors.Mean = MathUtils.Mean(errors.Values);
            errors.AbsMean = MathUtils.Mean(MathUtils.Abs(errors.Values));
            errors.Std = MathUtils.StandardDeviation(errors.Values, errors.Mean);

            errors.Minimum = errors.SortedValues[0];
            errors.Percent25 = errors.SortedValues[errors.SortedValues.Length * 25 / 100];
            errors.Percent50 = errors.SortedValues[errors.SortedValues.Length * 50 / 100];
            errors.Percent75 = errors.SortedValues[errors.SortedValues.Length * 75 / 100];
            errors.Maximum = errors.SortedValues[errors.SortedValues.Length - 1];
        }
    }
}
