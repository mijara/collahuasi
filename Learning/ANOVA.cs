using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class ANOVA
    {
        public double F;

        private TrainingJob job;

        public ANOVA(TrainingJob job)
        {
            this.job = job;
            Calculate();
        }

        private void Calculate()
        {
            var modelDegreesOfFreedom = 1;
            var errorDegreesOfFreedom = job.TestData.GetSize() - 2;

            var target = MathUtils.Flatten(job.TestData.AsArray(job.Target));
            var predictions = MathUtils.Flatten(job.Predictions);
            var mean = MathUtils.Mean(target);

            var modelSumOfSquares = MathUtils.SumOfSquares(predictions, mean);
            var errorSumOfSquares = MathUtils.SumOfSquares(target, predictions);

            var modelMeanSquare = modelSumOfSquares / modelDegreesOfFreedom;
            var errorMeanSquare = errorSumOfSquares / errorDegreesOfFreedom;

            F = modelMeanSquare / errorMeanSquare;
        }
    }
}
