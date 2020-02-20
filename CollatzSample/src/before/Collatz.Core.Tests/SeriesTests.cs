using System.Collections.Generic;
using System.Linq;
using Xunit;
using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using ApprovalTests.Reporters.Windows;

namespace Collatz.Core.Tests
{
    //TODO: Add UseReporter annotation to set default reporter
    //TODO: Add UseApprovalSubdirectory annotation to set file location
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

        [Fact]
        public void ValidateSeries()
        {
            int startValue = 10;
            var expectedSteps = new List<CollatzStep>
            {
                new CollatzStep {Step = 0, Value = 10},
                new CollatzStep {Step = 1, Value = 5},
                new CollatzStep {Step = 2, Value = 16},
                new CollatzStep {Step = 3, Value = 8},
                new CollatzStep {Step = 4, Value = 4},
                new CollatzStep {Step = 5, Value = 2},
                new CollatzStep {Step = 6, Value = 1}
            };
            var actualSteps = new CollatzSeries(startValue).Steps;

            for (int i = 0; i < expectedSteps.Count; i++)
            {
                Assert.Equal(expectedSteps[i].Step, actualSteps[i].Step);
                Assert.Equal(expectedSteps[i].Value, actualSteps[i].Value);
            }
        }

        [Fact (Skip = "Not Implemented")]
        public void ApproveSeriesSteps()
        {
            //TODO: Implement ApproveSeriesSteps() to replace ValidateSeries()
            // set the start value
            // get an enumerable of steps
            // verify all the steps 
        }

        [Fact (Skip = "Not Implemented")]
        public void ApproveSeries()
        {
            //TODO: Implement ApproveSeries() to approve the complex object
            // set the start value
            // get the series
            // verify the series
        }

    }
}
