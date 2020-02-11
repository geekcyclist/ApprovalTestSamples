using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;

namespace Collatz.Core.Tests
{
    public class SeriesTests
    {
        [Theory]
        [InlineData(16, 4)]
        [InlineData(35, 13)]
        [InlineData(41, 109)]
        public void SeriesContainsCorrectTotalSteps(int value, int expectedTotalSteps)
        {
            var series = new CollatzSeries(value);
            int actualTotalSteps = series.Steps.LastOrDefault().Step;
            Assert.Equal(expectedTotalSteps, actualTotalSteps);
        }
    }
}
