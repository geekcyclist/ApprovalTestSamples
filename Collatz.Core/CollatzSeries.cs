using System.Collections.Generic;
using System.Linq;

namespace Collatz.Core
{
    public class CollatzSeries
    {
        public int StartValue { get; private set; }
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

            var results = new List<CollatzStep>();
            results.Add(startElement);
            while (value > 1)
            {
                var mostRecentResult = results.Last();
                var result = CollatzStepCalculator.Calculate(mostRecentResult);
                value = result.Value;
                results.Add(result);
            }

            Steps = results;
        }
    }
}
