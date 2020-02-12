using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collatz.Core
{
    public class CollatzSeries
    {
        public int StartValue { get; }
        public List<CollatzStep> Steps { get; private set; }

        public CollatzSeries(int startValue)
        {
            StartValue = startValue;
            BuildSeriesSteps();
        }

        private void BuildSeriesSteps()
        {
            int value = StartValue;
            var startElement = new CollatzStep { Step = 0, Value = value };

            var results = new List<CollatzStep>
            {
                startElement
            };
            
            while (value > 1)
            {
                var mostRecentResult = results.Last();
                var result = CollatzStepCalculator.Calculate(mostRecentResult);
                value = result.Value;
                results.Add(result);
            }

            Steps = results;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Start Value: {StartValue}");
            builder.AppendLine($"Total Steps: {Steps.Count - 1}");
            foreach (var step in Steps)
            {
                builder.AppendLine($"\t{step.ToString()}");
            }

            return builder.ToString();
        }
    }
}
